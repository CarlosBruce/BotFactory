using Common.Tools;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Interface;
using Common;
using System.Collections.ObjectModel;

namespace Factories
{
    public class UnitFactory : IUnitFactory
    {
        private int _queueCapacity;
        private int _storageCapacity;


        private Thread oThread;

        public event EventHandler FactoryProgress;

        static bool _go;

        public List<IFactoryQueueElement> Queue
        {
            get
            {
                return _queue.ToList();
            }
            set { }
        }

        private List<IFactoryQueueElement> _queue { get; set; }

        private static readonly object obj = new object();
        public List<ITestingUnit> Storage
        {
            get { return _storage.ToList(); }
            set { }
        }

        private List<ITestingUnit> _storage { get; set; }


        public UnitFactory( int QueueCapacity, int StorageCapacity )
        {
            this._queueCapacity = QueueCapacity;
            this._storageCapacity = StorageCapacity;
            _go = false;
            _queue = new List<IFactoryQueueElement>();
            _storage = new List<ITestingUnit>();
            oThread = new Thread( new ThreadStart( () => BuildProcess() ) );
            oThread.Start();
        }

        public bool AddWorkableUnitToQueue( Type Model, string RobotName, Coordinates ParkPos, Coordinates WorkPos )
        {
            if( CanQueue() && CanStore() )
            {
                StartInitialiastion( Model, RobotName, ParkPos, WorkPos );
                return true;
            }
            return false;
        }

        private bool CanQueue()
        {
            if( _queue.Count() + 1 <= _queueCapacity )
                return true;

            return false;
        }

        public void BuildProcess()
        {

            System.Threading.Monitor.Enter( obj );
            try
            {
                if ( _queue.Count == 0)
                    Monitor.Wait( obj );
            }
            finally
            {
                Work();
                BuildProcess();
            }
        }
        private void Work()
        {
            ITestingUnit cur = Activator.CreateInstance( _queue.First().Model, new object[ ] { _queue.First().Name } ) as ITestingUnit;
            cur.WorkingPos = _queue.First().WorkingPos;
            cur.ParkingPos = _queue.First().ParkingPos;

            //Simulate Construction
            Thread.Sleep( ( int )( cur.RobotSpeed * cur.BuildTime ) * 1000 );
            QueueTime += TimeSpan.FromSeconds( ( int )( cur.RobotSpeed * cur.BuildTime ) );
            //Free from queue
            _queue.Remove( _queue.First() );

            //Add to storage
            _storage.Add( cur );
            OnUnitStatusChanged( new StatusChangedEventArgs() { NewStatus = String.Format( "Element on Storage => {0}", _storage.First().Name ) } );
        }

        private void StartInitialiastion( Type Model, string RobotName, Coordinates ParkPos, Coordinates WorkPos )
        {

            _queue.Add( new FactoryQueueElement() { Model = Model, Name = RobotName, ParkingPos = ParkPos, WorkingPos = WorkPos } );
            OnUnitStatusChanged( new StatusChangedEventArgs() { NewStatus = String.Format( "Element on Queue => {0}", _queue.First().Name ) } );

            if( System.Threading.Monitor.TryEnter( obj ) )
            {
                System.Threading.Monitor.Pulse( obj );
                Monitor.Exit( obj );
            }

        }

        private void OnUnitStatusChanged( StatusChangedEventArgs statusChangedEventArgs )
        {
            if( FactoryProgress != null )
            {
                FactoryProgress( this, statusChangedEventArgs );
            }
        }

        private bool CanStore()
        {
            if( _storage.Count() + (_queue.Count()+1) <= _storageCapacity )
                return true;
            return false;
        }

        public int QueueCapacity
        {
            get
            {
                return _queueCapacity;
            }
        }

        public int StorageCapacity
        {
            get
            {
                return _storageCapacity;
            }
        }

        public TimeSpan QueueTime
        {
            get; set;

        }

        public int QueueFreeSlots
        {
            get
            {
                return _queueCapacity - _queue.Count();
            }
            set { }
        }

        public int StorageFreeSlots
        {
            get
            {
                return _storageCapacity - _storage.Count();
            }

            set
            { }
        }
    }
}

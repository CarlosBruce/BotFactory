using Common;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Tools;
using System.Threading;

namespace Models
{
    public class Robot : WorkingUnit ,ITestingUnit, IRobot
    {

        public Robot( string robotName, double robotSpeed = 1 ) : base(robotName,robotSpeed)
        {
            this.Name = robotName;
            this.Model = "Robot";
            this.RobotSpeed = 1.5;
            this.BuildTime = 5.5;
            this.CurrentPos = new Coordinates();
        }

        public Robot( string robotName ) : base( robotName, 1.5 )
        {
            this.Name = robotName;
            this.Model = "Robot";
            this.RobotSpeed = 1.5;
            this.BuildTime = 5.5;
            this.CurrentPos = new Coordinates();
        }



        public double BuildTime
        { get; set; }

        public Coordinates CurrentPos
        { get; set; }

        public bool IsWorking
        { get; set; }

        public string Model { get; set; }

        public string Name
        { get; set; }

        public Coordinates ParkingPos { get; set; }

        public double RobotSpeed { get; set; }

        public Coordinates WorkingPos { get; set; }

        public event EventHandler<IStatusChangedEventArgs> UnitStatusChanged;

        public override async Task<bool> Move( Coordinates FinalPos )
        {
            try
            {
                // This method runs asynchronously.
                double t = await Task.Run(() => FindPath(FinalPos));
                Thread.Sleep( 1000 * ( int )this.RobotSpeed * ( int )t );
                this.CurrentPos.x = FinalPos.x;
                this.CurrentPos.y = FinalPos.y; 
            }
            catch
            { return false; }

            return true;
        }

        public override void OnStatusChanged( IStatusChangedEventArgs e)
        {
            if( UnitStatusChanged != null )
            {
                UnitStatusChanged( this, e );
            }
        }

        public override async Task<bool> SetParkingPosition()
        {
            OnStatusChanged( new StatusChangedEventArgs() { NewStatus = string.Format( "Moved {0} to Parking Position", this.Name ) } );
            if( this.WorkingPos != ParkingPos )
                return await this.Move( ParkingPos );
            return true;
        }

        public override async Task<bool> SetWorkingPosition()
        {
            OnStatusChanged( new StatusChangedEventArgs() { NewStatus = string.Format( "Moved {0} to Working Position", this.Name ) } );
            if( this.CurrentPos != WorkingPos )
                return await this.Move( WorkingPos );
            return true;
        }

        public override async Task<bool> WorkBegins()
        {
            this.IsWorking = true;
            bool result = await SetWorkingPosition();

            return result;
        }

        public override async Task<bool> WorkEnds()
        {
            this.IsWorking = false;
            return await SetParkingPosition();
        }


        private double FindPath( Common.Tools.Coordinates FinalPos )
        {
            Common.Tools.Vector v = new Common.Tools.Vector();

            return v.Lenght( this.CurrentPos, FinalPos );
        }
    }
}

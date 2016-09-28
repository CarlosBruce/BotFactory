using Common.Tools;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    public interface IUnitFactory 
    {
        event EventHandler FactoryProgress;

        List<IFactoryQueueElement> Queue { get; set; }

        List<ITestingUnit> Storage { get; set; }

        int QueueFreeSlots { get; set; }

         int StorageFreeSlots { get; set; }

        TimeSpan QueueTime { get; set; }

        bool AddWorkableUnitToQueue( Type Model, string RobotName, Coordinates ParkPos, Coordinates WorkPos );

        void BuildProcess();

        int QueueCapacity        {get;}

         int StorageCapacity    {get;}
        }
}


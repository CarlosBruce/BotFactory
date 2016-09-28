using Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IFactoryQueueElement
    {
        string Name { get; set; }

        Type Model { get; set; }

        Coordinates ParkingPos { get; set; }

        Coordinates WorkingPos { get; set; }
    }
}

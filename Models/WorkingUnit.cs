using Common.Tools;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class WorkingUnit : BaseUnit ,IWorkingUnit
    {
        public WorkingUnit( string robotName, double robotSpeed = 1 ) : base( robotName, robotSpeed )
        {
        }

        public Coordinates ParkingPos { get; set; }
        public Coordinates WorkingPos { get; set; }
        public bool IsWorking { get; set; }

        public virtual Task<bool> WorkBegins() { throw new NotImplementedException(); }

        public virtual Task<bool> SetWorkingPosition()
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> WorkEnds() { throw new NotImplementedException(); }

        public virtual Task<bool> SetParkingPosition()
        {
            throw new NotImplementedException();
        }
    }
}

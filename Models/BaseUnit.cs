using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Models
{
    public abstract class BaseUnit : BuildableUnit, IBaseUnit
    {
        private string _robotName;
        private double  _robotSpeed;
        public BaseUnit(string robotName, double robotSpeed = 1)
        {
            this._robotName = robotName;
            this._robotSpeed = robotSpeed;
            this.CurrentPos = new Common.Tools.Coordinates { x = 0, y = 0 };
        }

        public virtual async Task<bool> Move( Common.Tools.Coordinates FinalPos ) { return true; }

        public string Name { get { return this._robotName; } }

        public Common.Tools.Coordinates CurrentPos { get; set; }
        private double FindPath( Common.Tools.Coordinates FinalPos )
        {
            Common.Tools.Vector v = new Common.Tools.Vector();

            return v.Lenght( this.CurrentPos, FinalPos );
        }
    }
}

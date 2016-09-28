using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Tools
{
    public class Coordinates :ICoordinates
    {
        public double x {
            get { return _x; }
            set { _x = value; }
        }
        public double y
        {
            get { return _y; }
            set { _y = value; }
        }

        private double _x;
        private double _y;

        public Coordinates( double x = 0, double y = 0 )
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals( Object obj )
        {
            Coordinates coordinatesObj = obj as Coordinates;
            if( coordinatesObj == null )
                return false;
            else
                return x.Equals( coordinatesObj.x ) && y.Equals( coordinatesObj.y );
        }

    }
}

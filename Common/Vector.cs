using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Tools
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Vector FromCoordinates(Coordinates begin, Coordinates end) {
            Vector v =  new Vector();

            v.Y = end.y - begin.y;
            v.X = end.x - begin.x;

            return v;
        }


        public double Lenght( Coordinates begin, Coordinates end )
        {
            return Math.Sqrt( ( Math.Pow( end.y - begin.y, 2 ) + Math.Pow( end.x - begin.x, 2 ) ) );
        }
    }
}

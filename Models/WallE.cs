using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class WallE : Robot
    {
        public WallE( string robotName ) : base( robotName, 4 )
        {
            this.Model = "Wall-E";
            this.BuildTime = 2;
        }
    }
}

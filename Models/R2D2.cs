using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class R2D2 : Robot
    {
        public R2D2( string robotName) : base( robotName, 5.5 )
        {
            this.Model = "R2D2";
            this.BuildTime = 1.5;
        }
    }
}

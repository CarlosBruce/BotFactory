using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Hal : Robot
    {
        public Hal( string robotName ) : base( robotName, 7 )
        {
            this.Model = "HAL";
            this.BuildTime = 0.5;
        }
    }
}

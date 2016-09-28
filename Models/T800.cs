using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class T800 : Robot
    {
        public T800( string robotName ) : base( robotName, 10 )
        {
            this.Model = "T-800";
            this.BuildTime = 3;
        }
    }
}

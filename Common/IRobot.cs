using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IRobot
    {
        string Model { get; set; }

        double RobotSpeed { get; set; }
    }
}

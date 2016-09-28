using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class BuildableUnit : ReportingUnit , IBuildableUnit
    {
        public double BuildTime { get; set; }
        public string Model { get; set; }

        public BuildableUnit(double buildTime = 5)
        { }
    }
}

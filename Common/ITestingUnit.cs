using Common;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ITestingUnit : IBuildableUnit,IBaseUnit,IReportingUnit,IWorkingUnit,IRobot
    {
        
    }
}

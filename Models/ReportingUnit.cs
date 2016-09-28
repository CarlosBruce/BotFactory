using Common;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class ReportingUnit : IReportingUnit
    {
        public event EventHandler<IStatusChangedEventArgs> UnitStatusChanged;

        public virtual void OnStatusChanged(IStatusChangedEventArgs StatusChanged )
        {
            if( UnitStatusChanged != null )
            {
                UnitStatusChanged( this, StatusChanged );
            }
        }


    }
}

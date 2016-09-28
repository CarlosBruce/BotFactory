using Common;
using System;

namespace Interface
{
    public interface IReportingUnit
    {
        event  EventHandler<IStatusChangedEventArgs>  UnitStatusChanged;

        void OnStatusChanged( IStatusChangedEventArgs StatusChanged );
    }
}
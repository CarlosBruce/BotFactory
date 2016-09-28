namespace Common
{
    public class StatusChangedEventArgs : System.EventArgs, IStatusChangedEventArgs
    {
        public string NewStatus { get; set; }
    }
}
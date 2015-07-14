namespace Unilynq.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chat
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> LynQDate { get; set; }
        public Nullable<System.TimeSpan> LynQTime { get; set; }
        public Nullable<System.DateTime> LynQDT { get; set; }
    }
}

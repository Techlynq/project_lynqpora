//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModels.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UChat
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
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Unilynq.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LynQComment
    {
        public int Id { get; set; }
        public Nullable<int> PostID { get; set; }
        public string LynQName { get; set; }
        public string LynQFname { get; set; }
        public string LynQimg { get; set; }
        public Nullable<System.DateTime> ComDate { get; set; }
        public string LynQProg { get; set; }
        public string Comment { get; set; }
        public string Commimg { get; set; }
        public string imgDescrip { get; set; }
    }
}

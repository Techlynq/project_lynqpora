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
    
    public partial class LynQQueAn
    {
        public int Id { get; set; }
        public int realID { get; set; }
        public string LynQName { get; set; }
        public string LynQFname { get; set; }
        public string LynQimg { get; set; }
        public Nullable<System.DateTime> Ansdate { get; set; }
        public string Answer { get; set; }
        public string LynQSch { get; set; }
        public string LynQSchimg { get; set; }
        public string LynQProg { get; set; }
        public Nullable<int> Likes { get; set; }
        public Nullable<int> Dislikes { get; set; }
        public string LynQLikers { get; set; }
        public string LynQDislikers { get; set; }
        public string Ansimgs { get; set; }
        public string AnsChecked { get; set; }
    }
}

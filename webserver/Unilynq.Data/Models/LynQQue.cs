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
    
    public partial class LynQQue
    {
        public int Id { get; set; }
        public string QueryID { get; set; }
        public string LynQquery { get; set; }
        public string LynQquerier { get; set; }
        public string LynQFname { get; set; }
        public string LynQimg { get; set; }
        public string LynQSchimg { get; set; }
        public string LynQProg { get; set; }
        public string LynQSch { get; set; }
        public string QueryScope { get; set; }
        public Nullable<int> AnswersProv { get; set; }
        public Nullable<int> Likes { get; set; }
        public Nullable<int> DisLikes { get; set; }
        public string Likers { get; set; }
        public string Dislikers { get; set; }
        public string QueryStatus { get; set; }
        public string Queryimg { get; set; }
        public Nullable<System.DateTime> Quedate { get; set; }
    }
}

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
    
    public partial class LynQPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string LynQName { get; set; }
        public string LynQFname { get; set; }
        public string LynQimg { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        public Nullable<System.DateTime> ComDate { get; set; }
        public string Message { get; set; }
        public string LynQSch { get; set; }
        public string LynQSchimg { get; set; }
        public string LynQProg { get; set; }
        public Nullable<int> PostLikes { get; set; }
        public Nullable<int> PostDislikes { get; set; }
        public string LynQLikers { get; set; }
        public string LynQDislikers { get; set; }
        public string PostStartimg { get; set; }
        public string StartimgDescrip { get; set; }
        public string Postimgs { get; set; }
        public string imgDescrip { get; set; }
        public Nullable<int> PostComments { get; set; }
        public string PostScope { get; set; }
    }
}
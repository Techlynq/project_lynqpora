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
    
    public partial class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string LynQManager { get; set; }
        public string LynQFname { get; set; }
        public string LynQimg { get; set; }
        public string LynQSchimg { get; set; }
        public string LynQProg { get; set; }
        public string LynQSch { get; set; }
        public string Forum_Expo { get; set; }
        public string ForumScope { get; set; }
        public Nullable<int> Messages { get; set; }
        public string Forumimg { get; set; }
        public Nullable<System.DateTime> ForumDate { get; set; }
        public Nullable<int> Likes { get; set; }
        public Nullable<int> DisLikes { get; set; }
        public string Likers { get; set; }
        public string Dislikers { get; set; }
    }
}

namespace Unilynq.BusinessEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class LynQerEntity
    {
        public int Id { get; set; }
        public string LynQName { get; set; }
        public string LynQUserid { get; set; }
        public string LynQFstname { get; set; }
        public string LynQLstname { get; set; }
        public string LynQOnames { get; set; }
        public string LynQFname { get; set; }
        public string LynQGender { get; set; }
        public Nullable<System.DateTime> LynQAge { get; set; }
        public string LynQerimg { get; set; }
        public string LynQSch { get; set; }
        public string LynQSchimg { get; set; }
        public string LynQProg { get; set; }
        public string LynQStatus { get; set; }
        public string LynQTivity { get; set; }
        public string LynQInterest { get; set; }
        public string CommentsViewed { get; set; }
        public string Email { get; set; }
        public string Rakeit { get; set; }
        public byte[] N_image { get; set; }
        public byte[] G_image { get; set; }
        public byte[] I_image { get; set; }
        public string LynQLevell { get; set; }
        public Nullable<int> LynQActive { get; set; }
        public string LynQUniqID { get; set; }
        public string Privacy { get; set; }
    }
}

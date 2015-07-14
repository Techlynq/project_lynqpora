using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace Unilynq.WebApi.Filters
{
    public class BasicAuthenticationIdentity : GenericIdentity
    {
        public string Password { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public BasicAuthenticationIdentity(string lynqName, string password)
            : base(lynqName, "Basic")
        {
            Password = password;
            UserName = lynqName;
        }

        public int LynQId { get; set; }
    }
}
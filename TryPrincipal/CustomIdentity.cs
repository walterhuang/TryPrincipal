using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TryPrincipal
{
    public class CustomIdentity : IIdentity
    {
        public CustomIdentity(string name, string email, string[] roles)
        {
            Name = name;
            Email = email;
            Roles = roles;
        }

        public string Email { get; set; }
        public string[] Roles { get; set; }

        public string AuthenticationType
        {
            get
            {
                return "Custom authentication";
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return !string.IsNullOrEmpty(Name);
            }
        }

        public string Name
        {
            get; private set;
        }
    }

    public class AnonymousIdentity : CustomIdentity
    {
        public AnonymousIdentity() : base("", "", new string[] { })
        {

        }
    }
}

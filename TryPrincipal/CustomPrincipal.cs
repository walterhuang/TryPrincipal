﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TryPrincipal
{
    public class CustomPrincipal : IPrincipal
    {
        private CustomIdentity _identity;
        public CustomIdentity Identity
        {
            get
            {
                return _identity ?? new AnonymousIdentity();
            }
            set { _identity = value; }
        }

        IIdentity IPrincipal.Identity
        {
            get
            {
                return Identity;
            }
        }

        public bool IsInRole(string role)
        {
            return _identity.Roles.Contains(role);
        }
    }
}

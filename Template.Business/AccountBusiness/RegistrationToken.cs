using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Business.AccountBusiness
{
    public class RegistrationToken
    {
        public bool Results { get; set; }
        public string EmailConfimationToken { get; set; }
        public IdentityUser User { get; set; }
    }
}

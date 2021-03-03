using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core.Entities
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}

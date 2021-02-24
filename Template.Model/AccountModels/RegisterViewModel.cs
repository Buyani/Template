using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Model.AccountModels
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool RememberMe { get; set; }
    }
}

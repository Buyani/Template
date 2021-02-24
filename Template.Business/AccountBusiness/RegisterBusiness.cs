using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Model.AccountModels;

namespace Template.Business.AccountBusiness
{
    public class RegisterBusiness: IRegisterBusiness
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public RegisterBusiness(UserManager<IdentityUser> userManager,
                              SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> Register(RegisterViewModel model)
        {
            var user = new IdentityUser {UserName = model.Email,Email = model.Email};

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return true;
            }
            return false;
        }
        public async Task<bool> FindUser(string userName)
        {
            var user =await _userManager.FindByNameAsync(userName);

            if(user!=null)
            {
                return true;
            }
            return false;
        }
    }
}


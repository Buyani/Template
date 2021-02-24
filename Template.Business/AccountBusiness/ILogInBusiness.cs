using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Model.AccountModels;

namespace Template.Business.AccountBusiness
{
    public interface ILogInBusiness
    {
        Task<bool> LogUserIn(LoginModel model,bool RememberMe);
        Task LogOut();
    }
}

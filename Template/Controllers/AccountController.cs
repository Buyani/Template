using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Business.AccountBusiness;
using Template.Model.AccountModels;

namespace Template.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRegisterBusiness _registerbusiness;
        private readonly ILogInBusiness _loginbusiness;
        public AccountController(IRegisterBusiness registerbusiness, ILogInBusiness loginbusiness)
        {
            _registerbusiness = registerbusiness;
            _loginbusiness = loginbusiness;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                if (await _registerbusiness.FindUser(model.Email))
                {
                    ModelState.AddModelError("", "User with same username already exists");
                    return View(model);
                }

                var result = await _registerbusiness.Register(model);

                if (result)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", result.ToString());
                }
            }
            return View(model);
        }


        // GET: Login
        [AllowAnonymous]
        public ActionResult LogIn()
        {
            var loginview = new LoginModel();
            return View(loginview);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> LogIn(LoginModel model, string returnUrl,bool RememberMe)
        {
            if (ModelState.IsValid)
            {
                var results = await _loginbusiness.LogUserIn(model,RememberMe);
                if (results)
                    return RedirectToLocal(returnUrl);
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }

            return View(model);
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LogOff()
        {
            await _loginbusiness.LogOut();
            return RedirectToAction("Index", "Home");
        }
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Student");
            }
        }
    }
}

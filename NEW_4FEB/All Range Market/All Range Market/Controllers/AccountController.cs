﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using All_Range_Market.Models.ViewModels;
using All_Range_Market.Models;

namespace All_Range_Market.Controllers
{

    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        private RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signInMgr, RoleManager<IdentityRole> rlMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;
            roleManager = rlMgr;
        }
        [HttpGet]
        public ViewResult Login(string returnUrl)
        {
            return View(new LoginModel
            {
                ReturnUrl = returnUrl
            });
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                var result =
                await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                    if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register() => View(new RegisterModel());
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser { Email = registerModel.Email, UserName = registerModel.Email};
                var result = await userManager.CreateAsync(user, registerModel.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(registerModel);
        }
        [HttpGet]
        public IActionResult Forgotten() => View(new ForgottenModel());
        [HttpPost]
        public IActionResult Forgotten(ForgottenModel model)
        {
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Profile()
        {
            var userRoles = await userManager.GetRolesAsync(await userManager.GetUserAsync(HttpContext.User));
            switch(userRoles[0])
            {
                case "Admin": return RedirectToAction("ControlPanel", "Admin"); break;
                case "Brand": return RedirectToAction("Main", "ShopAdministration"); break;
                default: return View(User);
            }
            return NotFound();
        }
        [Authorize]
        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }
    }
}

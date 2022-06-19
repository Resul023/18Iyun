using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pustok.Models;
using Pustok.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser>userManager,SignInManager<AppUser>signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        public IActionResult Index()
        {
            AccountIndexViewModel vm = new AccountIndexViewModel
            {
                LoginVW = new MemberLoginViewModel(),
                RegisterVW = new MemberRegisterViewModel()
            };
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Register(MemberRegisterViewModel memberVW) 
        {
            if (!ModelState.IsValid)
            {
                return View("index", new AccountIndexViewModel { RegisterVW = memberVW});
            }

            AppUser newUser = new AppUser 
            { 
                UserName = memberVW.RegisterUserName,
                FullName = memberVW.FullName,
                Email = memberVW.Email,
                IsAdmin = false,
            };

            var result = await _userManager.CreateAsync(newUser, memberVW.RegisterPassword);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                   
                }
                return View("index");
            }
            await _userManager.AddToRoleAsync(newUser,"Member");
            return RedirectToAction("index");
        }
        [HttpPost]
        public async Task<IActionResult> Login(MemberLoginViewModel memberVW)
        {
            if (!ModelState.IsValid)
            {
                return View("index", new AccountIndexViewModel { LoginVW = memberVW , RegisterVW=new MemberRegisterViewModel () });
            }
            AppUser member =  _userManager.Users.FirstOrDefault(x=>!x.IsAdmin&&x.UserName == memberVW.LoginUserName);
            if (member == null)
            {
                ModelState.AddModelError("","UserName or Password is incorrect");
                return View("index", new AccountIndexViewModel { LoginVW = memberVW, RegisterVW = new MemberRegisterViewModel() });
            }
            var result = await _signInManager.PasswordSignInAsync(member, memberVW.LoginPassword,false,false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "UserName or Password is incorrect");
                return View("index", new AccountIndexViewModel { LoginVW = memberVW, RegisterVW = new MemberRegisterViewModel() });
            }
            return RedirectToAction("index","home");
        }

        public async Task<IActionResult> Logout() 
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home"); 
        }
    }
}

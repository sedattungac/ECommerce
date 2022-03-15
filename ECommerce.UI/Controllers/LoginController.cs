using ECommerce.Business.Abstract;
using ECommerce.UI.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ECommerce.UI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserService _userService;
        private readonly SignInManager<User> _signInManager;
        public LoginController(IHttpContextAccessor httpContextAccessor, IUserService userService, SignInManager<User> signInManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserMail, p.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Department");
                }
            }
            else
            {
                ModelState.AddModelError("", "Hatalı mail veya şifre");
            }

            return View();

        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }

    }
}

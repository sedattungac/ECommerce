using DataAccessLayer.Concrete;
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
        private readonly Context _context;
        public LoginController(IHttpContextAccessor httpContextAccessor, IUserService userService, Context context)
        {
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var userValue = _context.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);

            if (userValue != null)
            {
                HttpContext.Session.SetInt32("id", userValue.UserID);
                HttpContext.Session.SetString("email", userValue.Email);
                HttpContext.Session.SetString("fullname", userValue.UserFullName);
                return RedirectToAction("Index", "Department");
            }
            else
            {
                ViewBag.alert = "Hatalı Giriş! Lütfen tekrar deneyiniz!";

            }
            return View("Index","Login");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }

    }
}

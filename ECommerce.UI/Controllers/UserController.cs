using ECommerce.Business.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userManager;
        private readonly ITitleService _titleManager;
        private readonly IToastNotification _toast;

        public UserController(ITitleService titleManager, IUserService userManager, IToastNotification toast)
        {
            _userManager = userManager;
            _titleManager = titleManager;
            _toast = toast;
        }
        public IActionResult Index()
        {
            var userList = _userManager.GetListWithTitle();
            return View(userList);
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            List<SelectListItem> dropdownlist = (from x in _titleManager.GetAllList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.TitleName,
                                                     Value = x.TitleID.ToString()



                                                 }).ToList();
            ViewBag.list = dropdownlist;
            var userId = _userManager.GetById(id);
            return View(userId);
        }
        [HttpPost]
        public IActionResult EditUser(User user)
        {

            _userManager.UpdateUser(user);
            _toast.AddSuccessToastMessage("Ünvan düzenleme işlemi başarıyla gerçekleşti!");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            List<SelectListItem> dropdownlist = (from x in _titleManager.GetAllList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.TitleName,
                                                     Value = x.TitleID.ToString()



                                                 }).ToList();
            ViewBag.list = dropdownlist;
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _userManager.AddUser(user); _toast.AddSuccessToastMessage("Ünvan ekleme işlemi başarıyla gerçekleşti!");
            return RedirectToAction("Index");
        }
    }
}

using ECommerce.Business.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.Controllers
{
    public class UserRoleController : Controller
    {
        private readonly IUserRoleService _userRoleManager;
        private readonly IUserService _userManager;
        private readonly IRoleService _roleManager;

        public UserRoleController(IUserRoleService userRoleManager, IUserService userManager, IRoleService roleManager)
        {
            _userRoleManager = userRoleManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var userRoleList = _userRoleManager.GetListWithUser();
            return View(userRoleList);
        }
        [HttpGet]
        public IActionResult EditUserRole(int id)
        {
            List<SelectListItem> dropdownlist = (from x in _roleManager.GetAllList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.RoleName,
                                                     Value = x.RoleID.ToString()
                                                 }).ToList();
            ViewBag.list = dropdownlist;
            List<SelectListItem> dropdownlist2 = (from x in _userManager.GetAllList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.UserFullName,
                                                      Value = x.UserID.ToString()
                                                  }).ToList();
            ViewBag.list2 = dropdownlist2;

            var userRoleId = _userRoleManager.GetById(id);
            return View(userRoleId);
        }
        [HttpPost]
        public IActionResult EditUserRole(UserRole userRole)
        {
            _userRoleManager.UpdateUserRole(userRole);
            return RedirectToAction("Index");
        }

    }
}

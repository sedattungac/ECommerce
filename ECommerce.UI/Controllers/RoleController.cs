using ECommerce.Business.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _roleManager;
        private readonly IUserRoleService _userRoleManager;
        private readonly IApplicationService _applicationManager;
        private readonly IRoleApplicationService _roleapplicationManager;
        public RoleController(IUserRoleService userRoleManager, IRoleService roleManager, IApplicationService applicationManager, IRoleApplicationService roleApplicationManager)
        {
            _userRoleManager = userRoleManager;
            _roleManager = roleManager;
            _applicationManager = applicationManager;
            _roleapplicationManager = roleApplicationManager;
        }
        public IActionResult Index()
        {
            var values = _roleManager.GetAllList();
            return View(values);
        }
        [HttpPost]
        public IActionResult AddRole(Role role)
        {
            _roleManager.AddRole(role);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditRole(int id)
        {
            var roleId = _roleManager.GetRoleByIdWithRoleApplication(id);
            return View(roleId);
        }
        [HttpPost]
        public IActionResult EditRole(Role role)
        {
            _roleManager.UpdateRole(role);
            return RedirectToAction("Index", "Role");
        }

        [HttpPost]
        public IActionResult EditRoleApplication([FromBody] RoleViewModel roleViewModel)
        {
            var role = _roleManager.GetById(roleViewModel.RoleId);
            if (role != null)
            {
                var roleApplications = _roleapplicationManager.GetAllList(x => x.RoleID == role.RoleID).ToList();
                foreach (var item in roleViewModel.RoleApplicationViewModels)
                {
                    var isExistApplication = roleApplications.FirstOrDefault(x => x.ApplicationID == item.ApplicationId);
                    if (isExistApplication != null)
                    {
                        isExistApplication.IsAccessible = item.IsAccessible;
                        _roleapplicationManager.UpdateRoleApplication(isExistApplication);
                    }
                    else
                    {
                        _roleapplicationManager.AddRoleApplication(new RoleApplication
                        {
                            ApplicationID = item.ApplicationId,
                            RoleID = role.RoleID,
                            IsAccessible = item.IsAccessible,
                            RoleApplicationName = role.RoleName
                        });
                    }
                }
                return Json(null);
            }
            return BadRequest();
        }

        //[HttpGet]
        //public IActionResult AddRole()
        //{

        //    return View();
        //}
        //[HttpPost]
        //public IActionResult AddRole(Role role)
        //{
        //    _roleManager.AddRole(role);
        //    return RedirectToAction("Index", "Role");
        //}

    }
    public class RoleViewModel
    {
        public int RoleId { get; set; }
        public IEnumerable<RoleApplicationViewModel> RoleApplicationViewModels { get; set; }

    }

    public class RoleApplicationViewModel
    {
        public bool IsAccessible { get; set; }
        public int ApplicationId { get; set; }
    }
}

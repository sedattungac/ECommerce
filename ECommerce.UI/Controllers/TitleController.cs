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
    public class TitleController : Controller
    {
        private readonly ITitleService _titleManager;
        private readonly IDepartmentService _departmentManager;
        private readonly IToastNotification _toast;


        public TitleController(ITitleService titleManager, IDepartmentService departmentManager, IToastNotification toast)
        {
            _titleManager = titleManager;
            _departmentManager = departmentManager;
            _toast = toast;
        }
        public IActionResult Index()
        {
            var customerList = _titleManager.GetListWithDepartment();
            return View(customerList);
        }
        [HttpGet]
        public IActionResult EditTitle(int id)
        {
            List<SelectListItem> dropdownlist = (from x in _departmentManager.GetAllList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.DepartmentName,
                                                     Value = x.DepartmentID.ToString()



                                                 }).ToList();
            ViewBag.list = dropdownlist;
            var titleId = _titleManager.GetById(id);
            return View(titleId);
        }
        [HttpPost]
        public IActionResult EditTitle(Title title)
        {

            _titleManager.UpdateTitle(title);
            _toast.AddSuccessToastMessage("Ünvan güncelleme işlemi başarıyla gerçekleşti!");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddTitle()
        {
            List<SelectListItem> dropdownlist = (from x in _departmentManager.GetAllList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.DepartmentName,
                                                     Value = x.DepartmentID.ToString()



                                                 }).ToList();
            ViewBag.list = dropdownlist;
            return View();
        }
        [HttpPost]
        public IActionResult AddTitle(Title title)
        {
            _titleManager.AddTitle(title);
            _toast.AddSuccessToastMessage("Ünvan ekleme işlemi başarıyla gerçekleşti!");
            return RedirectToAction("Index");
        }

    }

}

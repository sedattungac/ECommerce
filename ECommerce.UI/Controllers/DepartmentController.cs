using DataAccessLayer.Concrete;
using ECommerce.Business.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IToastNotification _toast;
        public DepartmentController(IDepartmentService departmentService, IToastNotification toast)
        {
            _departmentService = departmentService;
            _toast = toast;
        }
        public IActionResult Index()
        {
            var departmentList = _departmentService.GetAllList();
            return View(departmentList);
        }
        [HttpGet]
        public IActionResult DepartmentAdd()
        {

            return View();
        }
        [HttpPost]
        public IActionResult DepartmentAdd(Department department)
        {

            _departmentService.AddDepartment(department);
            _toast.AddSuccessToastMessage("Departman ekleme işlemi başarıyla gerçekleşti!");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditDepartment(int id)
        {
            var getid = _departmentService.GetById(id);
            return View(getid);
        }
        [HttpPost]
        public IActionResult EditDepartment(Department department)
        {
            _departmentService.UpdateDepartment(department);
            _toast.AddSuccessToastMessage("Departman düzenleme işlemi başarıyla gerçekleşti!");
            return RedirectToAction("Index");
        }

        //public IActionResult GetDepartmentList()
        //{
        //    List<Department> list = _departmentService.GetAllList();
        //    return Json(list);
        //}
        //[HttpPost]
        //public IActionResult CreateDepartment(Department department)
        //{
        //    _departmentService.AddDepartment(department);
        //    return RedirectToAction("Index");

        //}
        //[HttpPost]
        //public IActionResult EditDepartment(Department department)
        //{
        //    _departmentService.UpdateDepartment(department);
        //    return RedirectToAction("Index");

        //}
        //[HttpPost]
        //public IActionResult DeleteDepartment(Department department)
        //{
        //    _departmentService.DeleteDepartment(department);
        //    return RedirectToAction("Index");
        //}

        //public JsonResult GetEditDeleteDepartment(int ID)
        //{
        //    var model = _departmentService.GetById(ID);
        //    string value = "";
        //    value = JsonConvert.SerializeObject(_departmentService, Formatting.Indented, new JsonSerializerSettings
        //    {
        //        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        //    });
        //    return Json(value);
        //}
    }
}

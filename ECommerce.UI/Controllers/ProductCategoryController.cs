using ECommerce.Business.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.Controllers
{
    public class ProductCategoryController : Controller
    {
        private readonly IProductCategoryService _productCategoryService;
        private readonly IToastNotification _toast;
        public ProductCategoryController(IProductCategoryService productCategoryService, IToastNotification toast)
        {
            _productCategoryService = productCategoryService;
            _toast = toast;
        }
        public IActionResult Index()
        {
            var categoryList = _productCategoryService.GetAllList();
            return View(categoryList);
        }
        [HttpPost]
        public IActionResult AddProductCategory(ProductCategory productCategory)
        {
            _productCategoryService.AddProductCategory(productCategory);
            _toast.AddSuccessToastMessage("Kategori ekleme işlemi başarıyla gerçekleşti!");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditProductCategory(int id)
        {
            var value = _productCategoryService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditProductCategory(ProductCategory productCategory)
        {
            _productCategoryService.UpdateCategory(productCategory);
            _toast.AddSuccessToastMessage("Kategori güncelleme işlemi başarıyla gerçekleşti!");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ProductCategoryDetail(int id)
        {
            var detail = _productCategoryService.GetById(id);
            return View(detail);
        }
    }
}

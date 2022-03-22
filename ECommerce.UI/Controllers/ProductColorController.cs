using DataAccessLayer.Concrete;
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
    public class ProductColorController : Controller
    {
        private readonly Context _context;

        private readonly IProductService _productService;
        private readonly IProductColorService _productColorService;
        private readonly IToastNotification _toast;
        public ProductColorController(Context context, IProductService productService, IProductColorService productColorService, IToastNotification toast)
        {
            _context = context;
            _productService = productService;
            _productColorService = productColorService;
            _toast = toast;
        }
        public IActionResult Index()
        {
            var value = _productColorService.GetAllList();
            return View(value);
        }
        [HttpGet]
        public IActionResult AddColor()
        {
            List<SelectListItem> dropdownlist1 = (from x in _context.Products.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.ProductName,
                                                      Value = x.ProductID.ToString()
                                                  }).ToList();
            ViewBag.list1 = dropdownlist1;
            return View();
        }
        [HttpPost]
        public IActionResult AddColor(ProductColor productColor)
        {
            _productColorService.AddProductColor(productColor);
            return RedirectToAction("Index");
        }
    }
}

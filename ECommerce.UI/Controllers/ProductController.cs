using DataAccessLayer.Concrete;
using ECommerce.Business.Abstract;
using ECommerce.Business.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;

namespace ECommerce.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly Context _context;
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;
        private readonly IToastNotification _toast;
        public ProductController(Context context, IProductService productService, IProductCategoryService productCategoryService, IToastNotification toast)
        {
            _context = context;
            _productService = productService;
            _productCategoryService = productCategoryService;
            _toast = toast;
        }
        public IActionResult ProductDetail(int id)
        {
            var values = _productService.GetById(id);
            return View(values);
        }
        public IActionResult ProductList()
        {
            var list = _productService.GetListWithCategory();

            return View(list);
        }
        public IActionResult Index()
        {
            //var list = _productService.GetAllList();
            //return View(list);
            return View();
        }
        [HttpPost]
        public IActionResult LoadData()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                // Skiping number of Rows count  
                var start = Request.Form["start"].FirstOrDefault();
                // Paging Length 10,20  
                var length = Request.Form["length"].FirstOrDefault();
                // Sort Column Name  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                // Sort Column Direction ( asc ,desc)  
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                // Search Value from (Search box)  
                var searchValue = Request.Form["search[value]"].FirstOrDefault();
                var claimNumber = Request.Form["columns[1][search][value]"].FirstOrDefault();
                var firstName = Request.Form["columns[2][search][value]"].FirstOrDefault();
                var lastName = Request.Form["columns[3][search][value]"].FirstOrDefault();
                var identityNumber = Request.Form["columns[4][search][value]"].FirstOrDefault();

                var value = (from customer in _context.Products select customer);

                //Paging Size (10,20,50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                // Getting all Customer data  
                var customerData = (from tempcustomer in _context.Products
                                    select tempcustomer);

                //Search

                if (!string.IsNullOrEmpty(claimNumber))
                    value = value.Where(x => x.ProductName.Contains(claimNumber));
                if (!string.IsNullOrEmpty(firstName))
                    value = value.Where(x => x.ProductCode.Contains(firstName));
                //if (!string.IsNullOrEmpty(lastName))
                //    value = value.Where(x => x.LastName.Contains(lastName));
                //if (!string.IsNullOrEmpty(identityNumber))
                //    value = value.Where(x => x.IdentityNum.Contains(identityNumber));


                //Sorting
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    value = value.OrderBy(sortColumn + " " + sortColumnDirection);
                }

                var customerCols = _context.Products.Select(x => new
                {
                    productID = x.ProductID,
                    productCode = x.ProductCode,
                    productName = x.ProductName,
                    productPrice = x.ProductPrice,
                    productStatus = x.ProductStatus.ToString(),
                    productCategory = x.ProductCategory.ProductCatName
                }).ToList();

                //Search  

                if (!string.IsNullOrEmpty(searchValue))
                {
                    value = value.Include(x => x.ProductCategory).Where(m => m.ProductID.ToString().Contains(searchValue)
                                                  || m.ProductName.Contains(searchValue)
                                                  || m.ProductCode.Contains(searchValue)
                                                  || m.ProductCategory.ProductCatName.ToString().Contains(searchValue));
                }


                //total number of rows count   
                recordsTotal = customerData.Count();
                //Paging   
                var data = value.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data  
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });

            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> dropdownlist1 = (from x in _context.ProductCategories.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.ProductCatName,
                                                      Value = x.ProductCatID.ToString()
                                                  }).ToList();
            ViewBag.list1 = dropdownlist1;

            Random rnd = new Random();
            int number1, number2, number3, number4, number5;

            int char1, char2, char3, char4;

            number1 = rnd.Next(1, 9);

            number2 = rnd.Next(0, 9);

            number3 = rnd.Next(0, 9);

            number4 = rnd.Next(1, 9);

            char1 = rnd.Next(65, 91);

            number5 = rnd.Next(65, 91);

            char2 = rnd.Next(65, 91);

            char3 = rnd.Next(65, 91);

            char4 = rnd.Next(65, 91);

            if (char1 == char2)
            {
                char2 = rnd.Next(65, 91);
            }

            if (char2 == char3)
            {
                char3 = rnd.Next(65, 91);
            }

            if (char3 == char4)
            {
                char4 = rnd.Next(65, 91);
            }

            if (number1 == number2)
            {
                number2 = rnd.Next(1, 9);
            }

            if (number2 == number3)
            {
                number3 = rnd.Next(0, 9);
            }

            if (number3 == number4)
            {
                number4 = rnd.Next(1, 9);
            }

            if (number4 == number5)

            {
                number5 = rnd.Next(0, 9);
            }

            char letter1;

            char letter2;

            char letter3;

            char letter4;

            letter1 = Convert.ToChar(char1);

            letter2 = Convert.ToChar(char2);

            letter3 = Convert.ToChar(char3);

            letter4 = Convert.ToChar(char4);

            string barcode = number1.ToString() + number2.ToString() + letter1 + number3.ToString() + number4.ToString() + letter2 + number4.ToString() + letter3 + number5.ToString() + letter4;
            ViewBag.barcode = barcode;
            Product v = new Product();
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.AddProduct(product);
            return RedirectToAction("ProductList");
        }
        [HttpGet]
        public IActionResult EditProduct()
        {
            List<SelectListItem> dropdownlist1 = (from x in _context.ProductCategories.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.ProductCatName,
                                                      Value = x.ProductCatID.ToString()
                                                  }).ToList();
            ViewBag.list1 = dropdownlist1;
            return View();
        }
        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            _productService.UpdateProduct(product);
            _toast.AddSuccessToastMessage("Ürün güncelleme işlemi başarıyla gerçekleşti!");
            return RedirectToAction("Index");
        }
        //[HttpPost]
        //public IActionResult ProductVisibility(int id)
        //{
        //    var edit = _productService.GetById(id);
        //    edit.ProductStatus = false;
        //    _context.SaveChanges();
        //    return RedirectToAction("ProductList", "Product");
        //}

    }
}

using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.Models.AddFile
{
    public class AddProduct
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public IFormFile ProductImage { get; set; }
        public bool ProductStatus { get; set; }

        public ICollection<ProductComment> ProductComments { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
        public int ProductCatID { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}

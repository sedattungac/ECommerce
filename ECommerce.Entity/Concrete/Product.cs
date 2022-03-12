using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public bool ProductStatus { get; set; }


        public ICollection<ProductComment> ProductComments { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }

        public int ProductCatID { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}

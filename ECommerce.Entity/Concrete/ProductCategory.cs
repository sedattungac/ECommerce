using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductCategory
    {
        [Key]
        public int ProductCatID { get; set; }
        public string ProductCatName { get; set; }
        public string ProductCatDescription { get; set; }
        public bool ProductCatStatus { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

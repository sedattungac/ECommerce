using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductColor
    {
        [Key]
        public int ProductColorID { get; set; }
        public string ProductColorTitle { get; set; }
        public string ProductColorCode { get; set; }
        public int ProductColorStock { get; set; }

        public ICollection<ProductSize> ProductSizes { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}

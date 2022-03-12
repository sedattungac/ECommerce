using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductImage
    {
        [Key]
        public int ProductImgID { get; set; }
        public string ProductImgTitle { get; set; }
        public string ProductImg { get; set; }

        public int ProductColorID { get; set; }
        public virtual ProductColor ProductColor { get; set; }
    }
}

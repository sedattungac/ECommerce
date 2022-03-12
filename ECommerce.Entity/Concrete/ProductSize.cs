using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductSize
    {
        [Key]
        public int ProductSizeID { get; set; }
        public int ProductSizeTitle { get; set; }

        public int ProductColorID { get; set; }
        public virtual ProductColor ProductColor { get; set; }
    }
}

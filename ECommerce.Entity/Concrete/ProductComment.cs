using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductComment
    {
        [Key]
        public int ProductComID { get; set; }
        public string ProductComDescription { get; set; }
        public int ProductComRating { get; set; }
        public bool ProductComStatus { get; set; }
        public DateTime ProductComDate { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}

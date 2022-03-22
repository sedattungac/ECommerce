using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Concrete
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            ShoppingCartCount = 1;
        }
        [Key]
        public int ShoppingCartID { get; set; }
        public int ShoppingCartCount { get; set; }
        public double ShoppingCartPrice { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }


    }
}

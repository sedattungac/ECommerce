using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Concrete
{
    public class CustomerAddress
    {
        [Key]
        public int CustomerAddressID { get; set; }
        public string CustomerAddressTitle { get; set; }
        public string CustomerAddressContent { get; set; }
        public string CustomerAddressProvince { get; set; }
        public string CustomerAddressdDistrict { get; set; }
        public int CustomerAddressPostCode { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

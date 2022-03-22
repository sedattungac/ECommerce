using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Concrete
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerTelephone { get; set; }
        public string CustomerIdentityNumber { get; set; }
        public string CustomerEMail { get; set; }
        public string CustomerPassword { get; set; }
        public ICollection<CustomerAddress> CustomerAddresses { get; set; }

    }
}

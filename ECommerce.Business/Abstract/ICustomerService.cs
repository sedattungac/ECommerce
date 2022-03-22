using ECommerce.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllList();
        void AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        Customer GetById(int id);
        Customer GetOne(Expression<Func<Customer, bool>> filter);
    }
}

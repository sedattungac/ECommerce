using DataAccessLayer.Concrete;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Repositories;
using ECommerce.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.EntityFramework
{
    public class EfCustomerAddressRepository : GenericRepository<CustomerAddress>, ICustomerAddressDal
    {
        private readonly Context _context;

        public EfCustomerAddressRepository(Context context) : base(context)
        {
            _context = context;

        }
        List<CustomerAddress> ICustomerAddressDal.GetListWithCustomer()
        {
            throw new NotImplementedException();
        }
    }
}

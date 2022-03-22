using DataAccessLayer.Concrete;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Repositories;
using ECommerce.Entity.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.EntityFramework
{
    public class EfCustomerRepository : GenericRepository<Customer>, ICustomerDal
    {
        private readonly Context _context;

        public EfCustomerRepository(Context context) : base(context)
        {
            _context = context;

        }

    }
}

using DataAccessLayer.Concrete;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.EntityFramework
{
    public class EfApplicationRepository : GenericRepository<Application>, IApplicationDal
    {
        public EfApplicationRepository(Context context) : base(context)
        {
        }

        //public List<Customer> GetListWith()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

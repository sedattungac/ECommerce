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
    public class EfRoleApplicationRepository : GenericRepository<RoleApplication>, IRoleApplicationDal
    {
        private readonly Context _context;
        public EfRoleApplicationRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}

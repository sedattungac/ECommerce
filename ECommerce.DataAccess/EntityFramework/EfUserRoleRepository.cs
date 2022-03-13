using DataAccessLayer.Concrete;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.EntityFramework
{
    public class EfUserRoleRepository : GenericRepository<UserRole>, IUserRoleDal
    {
        private readonly Context _context;
        public EfUserRoleRepository(Context context) : base(context)
        {
            _context = context;
        }

        public List<UserRole> GetListWithRole()
        {
            return _context.UserRoles.Include(x => x.Role).ToList();
        }

        public List<UserRole> GetListWithUser()
        {
            return _context.UserRoles.Include(x => x.User).ToList();
        }
    }
}

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
    public class EfRoleRepository : GenericRepository<Role>, IRoleDal
    {
        private readonly Context _context;
        public EfRoleRepository(Context context) : base(context)
        {
            _context = context;
        }
        public List<Role> GetListWithRoleApplication()
        {
            return _context.Roles.Include(x => x.RoleApplications).ToList();
        }

        public Role GetRoleByIdWithRoleApplication(int id)
        {
            return _context.Roles.Include(x => x.RoleApplications).FirstOrDefault(x => x.RoleID == id);
        }

        public List<Role> GetListWithUserRole()
        {
            return _context.Roles.Include(x => x.UserRoles).ToList();
        }
    }
}

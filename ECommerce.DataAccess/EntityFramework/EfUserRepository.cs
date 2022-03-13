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
    public class EfUserRepository : GenericRepository<User>, IUserDal
    {
        private readonly Context _context;

        public EfUserRepository(Context context) : base(context)
        {
            _context = context;

        }

        public List<User> GetListWithTitle()
        {
            return _context.Users.Include(x => x.Title)
                .ThenInclude(t => t.Department)
                .ToList();
        }

    }
}

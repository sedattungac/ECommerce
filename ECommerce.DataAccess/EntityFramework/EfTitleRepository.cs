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
    public class EfTitleRepository : GenericRepository<Title>, ITitleDal
    {
        private readonly Context _context;
        public EfTitleRepository(Context context) : base(context)
        {
            _context = context;
        }

        public List<Title> GetListWithDepartment()
        {
            return _context.Titles.Include(x => x.Department).ToList();
        }
    }
}

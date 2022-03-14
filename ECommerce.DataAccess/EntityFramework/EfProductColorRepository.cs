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
    public class EfProductColorRepository : GenericRepository<ProductColor>, IProductColorDal
    {
        private readonly Context _context;
        public EfProductColorRepository(Context context) : base(context)
        {
            _context = context;
        }
        public List<ProductColor> GetListWithProduct()
        {
            return _context.ProductColors.Include(x => x.Product).ToList();
        }
    }
}

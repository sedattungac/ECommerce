using ECommerce.DataAccess.Repositories;
using ECommerce.DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductDal
    {
        private readonly Context _context;

        public EfProductRepository(Context context) : base(context)
        {
            _context = context;

        }
        public List<Product> GetListWithCategory()
        {
            return _context.Products.Include(x => x.ProductCategory).ToList();
        }
    }
}

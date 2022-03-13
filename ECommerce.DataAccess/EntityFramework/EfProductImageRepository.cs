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
    public class EfProductImageRepository : GenericRepository<ProductImage>, IProductImageDal
    {
        private readonly Context _context;
        public EfProductImageRepository(Context context) : base(context)
        {
            _context = context;
        }
        public List<ProductImage> GetWithProductColor()
        {
            return _context.ProductImages.Include(x => x.ProductColor).ToList();
        }
    }
}

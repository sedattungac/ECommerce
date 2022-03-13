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
    public class EfProductCommentRepository : GenericRepository<ProductComment>, IProductCommentDal
    {
        private readonly Context _context;
        public EfProductCommentRepository(Context context):base(context)
        {
            _context = context;
        }
        public List<ProductComment> GetWithProduct()
        {
            return _context.ProductComments.Include(x => x.Product).ToList();
        }
    }
}

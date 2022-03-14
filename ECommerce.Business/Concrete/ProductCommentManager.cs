using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class ProductCommentManager : IProductCommentService
    {
        IProductCommentDal _productCommentDal;
        public ProductCommentManager(IProductCommentDal productCommentDal)
        {
            _productCommentDal = productCommentDal;
        }
        public void AddProductComment(ProductComment productComment)
        {
            _productCommentDal.Insert(productComment);
        }

        public void DeleteProductComment(ProductComment productComment)
        {
            _productCommentDal.Delete(productComment);
        }

        public List<ProductComment> GetAllList()
        {
            return _productCommentDal.GetListAll();
        }

        public ProductComment GetById(int id)
        {
            return _productCommentDal.GetById(id);
        }

        public List<ProductComment> GetListWithProduct()
        {
            return _productCommentDal.GetWithProduct();
        }

        public void UpdateProductComment(ProductComment productComment)
        {
            _productCommentDal.Update(productComment);

        }
    }
}

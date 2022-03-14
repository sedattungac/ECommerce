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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void AddProduct(Product product)
        {
            _productDal.Insert(product);
        }

        public void DeleteProduct(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAllList()
        {
            return _productDal.GetListAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> GetListWithCategory()
        {
            return _productDal.GetListWithCategory();
        }

        public void UpdateProduct(Product product)
        {
            _productDal.Update(product);
        }
    }
}

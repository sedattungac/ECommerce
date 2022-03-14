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
    public class ProductImageManager : IProductImageService
    {
        IProductImageDal _productImageDal;
        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }
        public void AddProductImage(ProductImage productImage)
        {
            _productImageDal.Insert(productImage);
        }

        public void DeleteProductImage(ProductImage productImage)
        {
            _productImageDal.Delete(productImage);
        }

        public List<ProductImage> GetAllList()
        {
            return _productImageDal.GetListAll();
        }

        public ProductImage GetById(int id)
        {
            return _productImageDal.GetById(id);
        }

        public List<ProductImage> GetListWithProduct()
        {
            return _productImageDal.GetWithProductColor();
        }

        public void UpdateProductImage(ProductImage productImage)
        {
            _productImageDal.Update(productImage);
        }
    }
}

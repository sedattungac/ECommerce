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
    public class ProductSizeManager : IProductSizeService
    {
        IProductSizeDal _productSizeDal;
        public ProductSizeManager(IProductSizeDal productSizeDal)
        {
            _productSizeDal = productSizeDal;
        }

        public void AddProductSize(ProductSize productSize)
        {
            _productSizeDal.Insert(productSize);
        }

        public void DeleteProductSize(ProductSize productSize)
        {
            _productSizeDal.Delete(productSize);
        }

        public List<ProductSize> GetAllList()
        {
            return _productSizeDal.GetListAll();
        }

        public ProductSize GetById(int id)
        {
            return _productSizeDal.GetById(id);
        }
        public List<ProductSize> GetListWithProductColor()
        {
            return _productSizeDal.GetWithProductColor();
        }
        public void UpdateProductSize(ProductSize productSize)
        {
            _productSizeDal.Update(productSize);
        }
    }
}

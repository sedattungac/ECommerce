using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IProductImageService
    {
        void AddProductImage(ProductImage productImage);
        void DeleteProductImage(ProductImage productImage);
        void UpdateProductImage(ProductImage productImage);
        List<ProductImage> GetListWithProduct();
        List<ProductImage> GetAllList();
        ProductImage GetById(int id);
    }
}

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IProductSizeService
    {
        void AddProductSize(ProductSize productSize);
        void DeleteProductSize(ProductSize productSize);
        void UpdateProductSize(ProductSize productSize);
        List<ProductSize> GetListWithProductColor();
        List<ProductSize> GetAllList();
        ProductSize GetById(int id);
    }
}

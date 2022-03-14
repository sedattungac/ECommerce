using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IProductColorService
    {
        void AddProductColor(ProductColor productColor);
        void DeleteProductColor(ProductColor productColor);
        void UpdateProductColor(ProductColor productColor);
        List<ProductColor> GetListWithProduct();
        List<ProductColor> GetAllList();

        ProductColor GetById(int id);
    }
}

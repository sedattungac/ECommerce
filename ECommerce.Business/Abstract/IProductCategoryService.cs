using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IProductCategoryService
    {
        void AddProductCategory(ProductCategory productCategory);
        void DeleteCategory(ProductCategory productCategory);
        void UpdateCategory(ProductCategory productCategory);
        List<ProductCategory> GetAllList();

        ProductCategory GetById(int id);
    }
}

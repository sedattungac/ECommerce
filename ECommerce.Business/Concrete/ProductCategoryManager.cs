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
    public class ProductCategoryManager : IProductCategoryService
    {
        IProductCategoryDal _productCategoryDal;
        public ProductCategoryManager(IProductCategoryDal productCategoryDal)
        {
            _productCategoryDal = productCategoryDal;
        }
        public void AddProductCategory(ProductCategory productCategory)
        {
            _productCategoryDal.Insert(productCategory);
        }

        public void DeleteCategory(ProductCategory productCategory)
        {
            _productCategoryDal.Delete(productCategory);
        }

        public List<ProductCategory> GetAllList()
        {
            return _productCategoryDal.GetListAll();
        }

        public ProductCategory GetById(int id)
        {
            return _productCategoryDal.GetById(id);
        }

        public void UpdateCategory(ProductCategory productCategory)
        {
            _productCategoryDal.Update(productCategory);
        }
    }
}

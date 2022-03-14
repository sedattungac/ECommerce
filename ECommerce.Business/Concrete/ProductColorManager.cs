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
    public class ProductColorManager : IProductColorService
    {
        IProductColorDal _productColorDal;
        public ProductColorManager(IProductColorDal productColorDal)
        {
            _productColorDal = productColorDal;
        }
        public void AddProductColor(ProductColor productColor)
        {
            _productColorDal.Insert(productColor);
        }

        public void DeleteProductColor(ProductColor productColor)
        {
            _productColorDal.Delete(productColor);
        }

        public List<ProductColor> GetAllList()
        {
            return _productColorDal.GetListAll();
        }

        public ProductColor GetById(int id)
        {
            return _productColorDal.GetById(id);
        }

        public List<ProductColor> GetListWithProduct()
        {
            return _productColorDal.GetListWithProduct();
        }

        public void UpdateProductColor(ProductColor productColor)
        {
            _productColorDal.Update(productColor);
        }
    }
}

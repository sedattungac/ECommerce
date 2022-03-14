using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IProductCommentService
    {
        void AddProductComment(ProductComment productComment);
        void DeleteProductComment(ProductComment productComment);
        void UpdateProductComment(ProductComment productComment);
        List<ProductComment> GetListWithProduct();
        List<ProductComment> GetAllList();
        ProductComment GetById(int id);

    }
}

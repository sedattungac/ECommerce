using ECommerce.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Abstract
{
    public interface IShoppignCartDal : IGenericDal<ShoppingCart>
    {
        List<ShoppingCart> GetListWithCustomer();
        List<ShoppingCart> GetListWithProduct();
    }
}

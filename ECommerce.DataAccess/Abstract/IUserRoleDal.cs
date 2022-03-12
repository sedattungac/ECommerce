using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Abstract
{
    public interface IUserRoleDal : IGenericDal<UserRole>
    {
        List<UserRole> GetListWithUser();
        List<UserRole> GetListWithRole();
    }
}

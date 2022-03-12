using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Abstract
{
    public interface IRoleDal : IGenericDal<Role>
    {
        List<Role> GetListWithUserRole();
        List<Role> GetListWithRoleApplication();
        Role GetRoleByIdWithRoleApplication(int id);
    }
}

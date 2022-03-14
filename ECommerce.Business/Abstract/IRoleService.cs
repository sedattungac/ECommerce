using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IRoleService
    {
        IEnumerable<Role> GetAllList();
        List<Role> GetListWithUserRole();
        List<Role> GetListWithRoleApplication();
        Role GetRoleByIdWithRoleApplication(int id);
        void AddRole(Role role);
        void DeleteRole(Role role);
        void UpdateRole(Role role);
        Role GetById(int id);
    }
}

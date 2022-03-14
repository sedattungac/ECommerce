using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IUserRoleService
    {
        IEnumerable<UserRole> GetAllList();
        void AddUserRole(UserRole userRole);
        void DeleteUserRole(UserRole userRole);
        void UpdateUserRole(UserRole userRole);
        UserRole GetById(int id);
        List<UserRole> GetListWithUser();
        List<UserRole> GetListWithRole();
    }
}

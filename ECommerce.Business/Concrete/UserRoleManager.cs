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
    public class UserRoleManager : IUserRoleService
    {
        private readonly IUserRoleDal _userRoleDal;

        public UserRoleManager(IUserRoleDal userRoleDal)
        {
            _userRoleDal = userRoleDal;
        }
        public void AddUserRole(UserRole userRole)
        {
            _userRoleDal.Insert(userRole);
        }

        public void DeleteUserRole(UserRole userRole)
        {
            _userRoleDal.Delete(userRole);
        }

        public IEnumerable<UserRole> GetAllList()
        {
            return _userRoleDal.GetListAll();
        }

        public UserRole GetById(int id)
        {
            return _userRoleDal.GetById(id);
        }

        public List<UserRole> GetListWithRole()
        {
            return _userRoleDal.GetListWithRole();
        }

        public List<UserRole> GetListWithUser()
        {
            return _userRoleDal.GetListWithUser();
        }

        public void UpdateUserRole(UserRole userRole)
        {
            _userRoleDal.Update(userRole);
        }
    }
}

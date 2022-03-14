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
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }
        public void AddRole(Role role)
        {
            _roleDal.Insert(role);
        }


        public void DeleteRole(Role role)
        {
            _roleDal.Delete(role);
        }

        public IEnumerable<Role> GetAllList()
        {
            return _roleDal.GetListAll();
        }

        public Role GetById(int id)
        {
            return _roleDal.GetById(id);
        }

        public List<Role> GetListWithRoleApplication()
        {
            return _roleDal.GetListWithRoleApplication();
        }

        public List<Role> GetListWithUserRole()
        {
            return _roleDal.GetListWithUserRole();
        }

        public Role GetRoleByIdWithRoleApplication(int id)
        {
            return _roleDal.GetRoleByIdWithRoleApplication(id);
        }

        public void UpdateRole(Role role)
        {
            _roleDal.Update(role);
        }
    }
}

using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class RoleApplicationManager : IRoleApplicationService
    {
        private readonly IRoleApplicationDal _roleApplicationDal;

        public RoleApplicationManager(IRoleApplicationDal roleApplicationDal)
        {
            _roleApplicationDal = roleApplicationDal;
        }
        public void AddRoleApplication(RoleApplication roleApplication)
        {
            _roleApplicationDal.Insert(roleApplication);
        }

        public void DeleteRoleApplication(RoleApplication roleApplication)
        {
            _roleApplicationDal.Delete(roleApplication);
        }

        public IEnumerable<RoleApplication> GetAllList(Expression<Func<RoleApplication, bool>> filter = null)
        {
            return _roleApplicationDal.GetListAll(filter);
        }

        public RoleApplication GetById(int id)
        {
            return _roleApplicationDal.GetById(id);
        }

        public void UpdateRoleApplication(RoleApplication roleApplication)
        {
            _roleApplicationDal.Update(roleApplication);
        }
    }
}

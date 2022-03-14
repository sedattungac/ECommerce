using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IRoleApplicationService
    {
        IEnumerable<RoleApplication> GetAllList(Expression<Func<RoleApplication, bool>> filter = null);
        void AddRoleApplication(RoleApplication roleApplication);
        void DeleteRoleApplication(RoleApplication roleApplication);
        void UpdateRoleApplication(RoleApplication roleApplication);
        RoleApplication GetById(int id);

    }
}

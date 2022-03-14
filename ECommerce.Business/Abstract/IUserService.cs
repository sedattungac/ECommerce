using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IUserService
    {
        IEnumerable<User> GetAllList();
        void AddUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
        User GetById(int id);
        List<User> GetListWithTitle();
        User GetOne(Expression<Func<User, bool>> filter);

    }
}

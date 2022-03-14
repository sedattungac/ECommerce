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
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userrDal)
        {
            _userDal = userrDal;
        }

        public User GetOne(Expression<Func<User, bool>> filter)
        {
            return _userDal.Get(filter);
        }

        public IEnumerable<User> GetAllList()
        {
            return _userDal.GetListAll();
        }

        public void AddUser(User user)
        {
            _userDal.Insert(user);
        }

        public void DeleteUser(User user)
        {
            _userDal.Delete(user);
        }

        public void UpdateUser(User user)
        {
            _userDal.Update(user);
        }

        public User GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<User> GetListWithTitle()
        {
            return _userDal.GetListWithTitle();
        }
    }
}

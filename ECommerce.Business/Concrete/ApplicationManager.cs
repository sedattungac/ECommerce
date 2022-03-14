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
    public class ApplicationManager : IApplicationService
    {
        IApplicationDal _applicationDal;
        public ApplicationManager(IApplicationDal applicationDal)
        {
            _applicationDal = applicationDal;
        }
        public void AddApplication(Application application)
        {
            _applicationDal.Insert(application);
        }

        public void DeleteApplication(Application application)
        {
            _applicationDal.Delete(application);
        }

        public List<Application> GetAllList()
        {
            return _applicationDal.GetListAll();
        }

        public Application GetById(int id)
        {
            return _applicationDal.GetById(id);
        }

        public void UpdateApplication(Application application)
        {
            _applicationDal.Update(application);
        }
    }
}

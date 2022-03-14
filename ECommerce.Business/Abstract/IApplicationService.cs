using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IApplicationService
    {
        void AddApplication(Application application);
        void DeleteApplication(Application application);
        void UpdateApplication(Application application);
        List<Application> GetAllList();
        Application GetById(int id);
    }
}

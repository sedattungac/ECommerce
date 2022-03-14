using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface ITitleService
    {
        void AddTitle(Title title);
        void DeleteTitle(Title title);
        void UpdateTitle(Title title);
        List<Title> GetAllList();
        Title GetById(int id);
        List<Title> GetListWithDepartment();
    }
}

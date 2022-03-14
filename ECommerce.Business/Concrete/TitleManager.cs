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
    public class TitleManager : ITitleService
    {
        ITitleDal _titleDal;

        public TitleManager(ITitleDal titleDal)
        {
            _titleDal = titleDal;
        }

        public void AddTitle(Title title)
        {
            _titleDal.Insert(title);
        }

        public void DeleteTitle(Title title)
        {
            _titleDal.Delete(title);
        }

        public List<Title> GetAllList()
        {
            return _titleDal.GetListAll();
        }

        public Title GetById(int id)
        {
            return _titleDal.GetById(id);
        }

        public List<Title> GetListWithDepartment()
        {
            return _titleDal.GetListWithDepartment();
        }

        public void UpdateTitle(Title title)
        {
            _titleDal.Update(title);
        }
    }
}

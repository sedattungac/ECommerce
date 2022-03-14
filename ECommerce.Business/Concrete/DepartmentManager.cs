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
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;
        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }
        public void AddDepartment(Department department)
        {
            _departmentDal.Insert(department);
        }

        public void DeleteDepartment(Department department)
        {
            _departmentDal.Delete(department);
        }

        public List<Department> GetAllList()
        {
            return _departmentDal.GetListAll();
        }

        public Department GetById(int id)
        {
            return _departmentDal.GetById(id);
        }

        public void UpdateDepartment(Department department)
        {
            _departmentDal.Update(department);
        }
    }
}

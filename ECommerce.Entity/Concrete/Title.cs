using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Title
    {
        [Key]
        public int TitleID { get; set; }
        public string TitleName { get; set; }
        public ICollection<User> Users { get; set; }
        public virtual Department Department { get; set; }
        public int DepartmentID { get; set; }

    }
}

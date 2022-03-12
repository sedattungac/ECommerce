using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class RoleApplication
    {
        [Key]
        public int RoleApplicationID { get; set; }
        public string RoleApplicationName { get; set; }
        public bool IsAccessible { get; set; } = false;



        public int ApplicationID { get; set; }
        public virtual Application Application { get; set; }
        public int RoleID { get; set; }
        public virtual Role Role { get; set; }



    }
}

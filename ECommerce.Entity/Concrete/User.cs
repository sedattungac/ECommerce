using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual Title Title { get; set; }
        public int TitleID { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }


    }
}

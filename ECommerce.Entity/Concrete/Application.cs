using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Application
    {
        [Key]
        public int ApplicationID { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationIcon { get; set; }
        public int ApplicationParent { get; set; }
        public string ApplicationValue { get; set; }
        public int ApplicationisMenu { get; set; }
        public string ApplicationHref { get; set; }
        public ICollection<RoleApplication> RoleApplications { get; set; }

    }
}

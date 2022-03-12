﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<RoleApplication> RoleApplications { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }

    }
}

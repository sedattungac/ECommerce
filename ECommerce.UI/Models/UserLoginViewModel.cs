using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Email adresi")]
        [Required(ErrorMessage ="Email adresini giriniz...!")]
        public string UserMail { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi giriniz...!")]
        public string Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DentistCalendar.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Belirtin.")]
        [Display(Name= "Kullanıcı Adınız:")]
       public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Adınızı Belirtin.")]
        [Display(Name = "Adınız:")]
       public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soy Adınızı Belirtin.")]
        [Display(Name = "Soyadınız:")]
       public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Belirtin.")]
        [Display(Name = "Şifreniz:")]
        [DataType(DataType.Password)]
       public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Emialinizi Belirtin.")]
        [Display(Name = "Emailiniz:")]
        [EmailAddress(ErrorMessage = "Lütfen Email Alanını Kontrol Einiz.")]
       public string Email { get; set; }
        
        [Display(Name = "Randavu Rengi:")]
       public string Color { get; set; }

        [Display(Name = "Doktorum")]
       public bool IsDentist { get; set; }

    }
}

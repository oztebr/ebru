using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goldStore.Models.ViewModel
{
    public class Login
    {
        [Display(Name ="Eposta")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Gerçerli bir Email Adresi giriniz")]
        [Required(ErrorMessage = "Boş bırakılmaz")]
        public string email { get; set; }

        [Display(Name = "Parola")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Parolanın minumum 6 karakter olması gerekir.")]
        [Required(ErrorMessage ="Boş bırakılmaz")]
        public string password { get; set; }

        [Display(Name = "Beni Hatırla")]
        public bool rememberMe { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicTechMVC.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(100, MinimumLength =2)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Keep me logged in")]
        public bool RememberMe { get; set; }
        public string LoginInvalid { get; set; }
    }
}

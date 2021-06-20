using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestUngDung.Areas.AdminTV.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { set; get; }
        public string Password { set; get; }
        public bool RememberMe { set; get; }
    }
}
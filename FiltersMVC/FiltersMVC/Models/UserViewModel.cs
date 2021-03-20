using FiltersMVC.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FiltersMVC.Models
{
    public class UserViewModel
    {
        [NonEmptyRequired]
        [Display(Name = "User login")]
        public string Login { get; set; }

        public string Email { get; set; }

        [NonEmptyRequired]
        public string Password { get; set; }
    }
}
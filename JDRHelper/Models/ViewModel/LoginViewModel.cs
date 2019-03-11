using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JDRHelper.Models.ViewModel
{
    public class LoginViewModel
    {
        private string _Email;
        private string _password;

        [Required]
        [EmailAddress]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get => _password; set => _password = value; }

    }
}
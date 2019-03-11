using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JDRHelper.Models.ViewModel
{
    public class ContactViewModel
    {
        private string _Nom;
        private string _Prenom;
        private string _Email;
        private string _Objet;
        private string _Message;

        [Required]
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        [Required]
        public string Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }

        [Required]
        [EmailAddress]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [Required]
        public string Objet
        {
            get { return _Objet; }
            set { _Objet = value; }
        }

        [Required]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
    }
}
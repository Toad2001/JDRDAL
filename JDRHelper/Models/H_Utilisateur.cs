using JDRBusiness.Services;
using JDRHelper.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JDRHelper.Models
{
    public class H_Utilisateur
    {
        B_RolesService rs = new B_RolesService();
        B_Role_UtilisateurService rus = new B_Role_UtilisateurService();

        private int _Id;
        private string _Nom;
        private string _Prenom;
        private string _Login;
        private string _Password;
        private string _Role;
        private string _Email;
        private bool _Active;
        private string _confirmPasword;

        [HiddenInput(DisplayValue = false)]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

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
        public string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }

        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        [Required]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare(nameof(Password))]//Compare les pswd pour etre sur qu'ils sont les meme
        public string ConfirmPasword { get => _confirmPasword; set => _confirmPasword = value; }

        public string Role
        {
            get { return _Role = rs.Get().Where(r=> r.Id == (rus.Get().Where(u => u.Id_Utilisateur == Id).Select(ro => ro.Id_Role).FirstOrDefault())).Select(r => r.Nom).FirstOrDefault(); }
            set { _Role = value; }
        }

        [Required]
        [EmailAddress]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        //[HiddenInput(DisplayValue = false)]
        //public int Id_PJ { get => _Id_PJ; set => _Id_PJ = value; }

        [HiddenInput(DisplayValue = false)]
        public bool Active
        {
            get { return _Active; }
            set { _Active = value; }
        }
    }
}

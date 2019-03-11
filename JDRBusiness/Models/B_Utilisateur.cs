using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Models
{
    public class B_Utilisateur
    {
        private int _Id;
        private string _Nom;
        private string _Prenom;
        private string _Login;
        private string _Password;
        private string _Email;
        private bool _Active;
        private int _Id_PJ;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        public string Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }

        public string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }       

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public bool Active
        {
            get { return _Active; }
            set { _Active = value; }
        }

        public int Id_PJ
        {
            get { return _Id_PJ; }
            set { _Id_PJ = value; }
        }

        public B_Utilisateur()
        {

        }

        public B_Utilisateur(int id, string nom , string prenom , string login, string password, int id_pj, string email , bool active )
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Login = login;
            Password = password;
            Id_PJ = id_pj;           
            Email = email;
            Active = active;
        }
    }
}

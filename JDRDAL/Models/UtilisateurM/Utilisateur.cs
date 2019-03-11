using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models
{
    public class Utilisateur
    {
        private int _Id;
        private string _Nom;
        private string _Prenom;
        private string _Login;
        private string _Password;
        private string _Email;
        private bool _Active;
                    
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
    }
}

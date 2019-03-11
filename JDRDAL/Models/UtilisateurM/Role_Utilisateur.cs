using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models.UtilisateurM
{
    public class Role_Utilisateur
    {
        private int _ID;

        public int Id
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private int _Id_Utilisateur;

        public int Id_Utilisateur
        {
            get { return _Id_Utilisateur; }
            set { _Id_Utilisateur = value; }
        }

        public int Id_Role { get; set; }

    }
}

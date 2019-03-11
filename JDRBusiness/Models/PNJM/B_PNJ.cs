using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Models
{
    public class B_PNJ
    {

        private int _Id;
        private string _Nom;
        private bool _Sexe;
        private int _Id_Race;
        private int _Id_Ame;
        private int _Id_Rang;
        private int _Id_ClassePNJ;

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

        public bool Sexe
        {
            get { return _Sexe; }
            set { _Sexe = value; }
        }

        public int Id_Race
        {
            get { return _Id_Race; }
            set { _Id_Race = value; }
        }

        public int Id_Ame
        {
            get { return _Id_Ame; }
            set { _Id_Ame = value; }
        }

        public int Id_Rang
        {
            get { return _Id_Rang; }
            set { _Id_Rang = value; }
        }

        public int Id_ClassePNJ
        {
            get { return _Id_ClassePNJ; }
            set { _Id_ClassePNJ = value; }
        }
    }
}

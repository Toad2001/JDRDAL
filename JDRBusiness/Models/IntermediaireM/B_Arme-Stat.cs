using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Models.Intermediaire
{
    public class B_Arme_Stat
    {
        private int _Id;
        private int _Id_Arme;
        private int _Id_Stat;
        private int _Valeur;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }        

        public int Id_Arme
        {
            get { return _Id_Arme; }
            set { _Id_Arme = value; }
        }        

        public int Id_Stat
        {
            get { return _Id_Stat; }
            set { _Id_Stat = value; }
        }        

        public int Valeur
        {
            get { return _Valeur; }
            set { _Valeur = value; }
        }

    }
}

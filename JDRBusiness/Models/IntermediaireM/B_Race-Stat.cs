using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Models.Intermediaire
{
    public class B_Race_Stat
    {
        private int _Id;
        private int _Id_Race;
        private int _Id_Stat;
        private int _Valeur;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int Id_Race
        {
            get { return _Id_Race; }
            set { _Id_Race = value; }
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

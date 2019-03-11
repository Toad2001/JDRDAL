using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRHelper.Models.Intermediaire
{
    public class H_Classe_Stat
    {
        private int _Id;
        private int _Id_Classe;
        private int _Id_Stat;
        private int _Valeur;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }        

        public int Id_Classe
        {
            get { return _Id_Classe; }
            set { _Id_Classe = value; }
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

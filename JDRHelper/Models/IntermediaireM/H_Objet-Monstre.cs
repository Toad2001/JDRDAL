using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRHelper.Models.Intermediaire
{
    public class H_Objet_Monstre
    {
        private int _Id_Objet;
        private int _Id_Monstre;

        public int Id_Objet
        {
            get { return _Id_Objet; }
            set { _Id_Objet = value; }
        }        

        public int Id_Monstre
        {
            get { return _Id_Monstre; }
            set { _Id_Monstre = value; }
        }
    }
}

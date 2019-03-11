using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRHelper.Models.Intermediaire
{
    public class H_Lieu_Monstre
    {
        private int _Id_Monstre;
        private int _Id_Lieu;

        public int Id_Monstre
        {
            get { return _Id_Monstre; }
            set { _Id_Monstre = value; }
        }        

        public int Id_Lieu
        {
            get { return _Id_Lieu; }
            set { _Id_Lieu = value; }
        }
    }
}

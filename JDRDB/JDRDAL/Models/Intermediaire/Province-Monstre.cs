using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models.Intermediaire
{
    public class Province_Monstre
    {
        private int _Id_Monstre;
        private int _Id_Province;

        public int Id_Monstre
        {
            get { return _Id_Monstre; }
            set { _Id_Monstre = value; }
        }

        public int Id_Province
        {
            get { return _Id_Province; }
            set { _Id_Province = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models.Intermediaire.PNJ
{
    public class PNJ_Armure
    {
        private int _Id_PNJ;
        private int _Id_Armure;

        public int Id_PNJ
        {
            get { return _Id_PNJ; }
            set { _Id_PNJ = value; }
        }

        public int Id_Armure
        {
            get { return _Id_Armure; }
            set { _Id_Armure = value; }
        }
    }
}

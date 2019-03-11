using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models.Intermediaire.PNJ
{
    public class PNJ_Arme
    {
        private int _Id_PNJ;
        private int _Id_Arme;

        public int Id_PNJ
        {
            get { return _Id_PNJ; }
            set { _Id_PNJ = value; }
        }

        public int Id_Arme
        {
            get { return _Id_Arme; }
            set { _Id_Arme = value; }
        }
    }
}

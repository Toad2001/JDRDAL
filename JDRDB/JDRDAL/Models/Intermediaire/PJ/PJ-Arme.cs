using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models.Intermediaire
{
    public class PJ_Arme
    {
        private int _Id_PJ;
        private int _Id_Arme;

        public int Id_PJ
        {
            get { return _Id_PJ; }
            set { _Id_PJ = value; }
        }

        public int Id_Arme
        {
            get { return _Id_Arme; }
            set { _Id_Arme = value; }
        }
    }
}

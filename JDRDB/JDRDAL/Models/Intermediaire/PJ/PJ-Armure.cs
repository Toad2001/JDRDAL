using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models.Intermediaire
{
    public class PJ_Armure
    {
        private int _Id_PJ;
        private int _Id_Armure;

        public int Id_PJ
        {
            get { return _Id_PJ; }
            set { _Id_PJ = value; }
        }

        public int Id_Armure
        {
            get { return _Id_Armure; }
            set { _Id_Armure = value; }
        }
    }
}

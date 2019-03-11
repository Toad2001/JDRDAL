using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Models.Intermediaire
{
    public class B_PJ_Magie
    {
        private int _Id_PJ;
        private int _Id_Magie;

        public int Id_PJ
        {
            get { return _Id_PJ; }
            set { _Id_PJ = value; }
        }

        public int Id_Magie
        {
            get { return _Id_Magie; }
            set { _Id_Magie = value; }
        }
    }
}

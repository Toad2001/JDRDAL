using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRHelper.Models.Intermediaire
{
    public class H_PJ_Equipement
    {
        private int _Id_PJ;
        private int _Id_Equipement;

        public int Id_PJ
        {
            get { return _Id_PJ; }
            set { _Id_PJ = value; }
        }

        public int Id_Equipement
        {
            get { return _Id_Equipement; }
            set { _Id_Equipement = value; }
        }
    }
}

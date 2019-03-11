using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRHelper.Models.Intermediaire
{
    public class H_PJ_Objet
    {
        private int _Id_PJ;
        private int _Id_Objet;

        public int Id_PJ
        {
            get { return _Id_PJ; }
            set { _Id_PJ = value; }
        }

        public int Id_Objet
        {
            get { return _Id_Objet; }
            set { _Id_Objet = value; }
        }
    }
}

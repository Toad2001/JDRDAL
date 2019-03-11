using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models.Intermediaire
{
    public class Style_Arme
    {
        private int _Id_Style;
        private int _Id_Arme;

        public int Id_Style
        {
            get { return _Id_Style; }
            set { _Id_Style = value; }
        }

        public int Id_Arme
        {
            get { return _Id_Arme; }
            set { _Id_Arme = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Models.Intermediaire
{
    public class B_Style_Armure
    {
        private int _Id_Style;
        private int _Id_Armure;

        public int Id_Style
        {
            get { return _Id_Style; }
            set { _Id_Style = value; }
        }

        public int Id_Armure
        {
            get { return _Id_Armure; }
            set { _Id_Armure = value; }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRHelper.Models.Intermediaire.PNJ
{
    public class H_PNJ_Magie
    {
        private int _Id_PNJ;
        private int _Id_Magie;

        public int Id_PNJ
        {
            get { return _Id_PNJ; }
            set { _Id_PNJ = value; }
        }

        public int Id_Magie
        {
            get { return _Id_Magie; }
            set { _Id_Magie = value; }
        }
    }
}

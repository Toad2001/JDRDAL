﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRHelper.Models
{
    public class H_Lieu
    {
        private int _Id;
        private string _Nom;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }
    }
}

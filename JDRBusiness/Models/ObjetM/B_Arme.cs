﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Models
{
    public class B_Arme
    {
        private int _Id;
        private string _Nom;        
        private int _Id_Typearme;
        private int _Malus;
        private bool _TailleArme;

        

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

        public int Id_TypeArme
        {
            get { return _Id_Typearme; }
            set { _Id_Typearme = value; }
        }

        public int Malus
        {
            get { return _Malus; }
            set { _Malus = value; }
        }

        public bool TailleArme
        {
            get { return _TailleArme; }
            set { _TailleArme = value; }
        }
    }
}

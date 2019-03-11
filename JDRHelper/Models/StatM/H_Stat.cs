using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDRHelper.Models
{
    public class H_Stat
    {
        private int _Id;
        private string _Nom;
        private int _Id_ClasseStat;

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

        public int Id_ClasseStat
        {
            get { return _Id_ClasseStat; }
            set { _Id_ClasseStat = value; }
        }
    }
}
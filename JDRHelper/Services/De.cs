using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDRHelper.Services
{
    public class De
    {
        private int _maximum;
        private static Random _rd = new Random();

        public De(int nbFaces)
        {
            this.Maximum = nbFaces;
        }

        public static Random Rd
        {
            get { return _rd; }
            set { _rd = value; }
        }

        private int Minimum
        {
            get { return 1; }
        }

        public int Maximum
        {
            get { return _maximum; }
            private set { _maximum = value; }
        }


        public int Lancer()
        {
            return Rd.Next(Minimum, Maximum + 1);
        }
    }
}
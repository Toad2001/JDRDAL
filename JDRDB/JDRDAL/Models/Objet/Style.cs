using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models
{
    public class Style
    {
        private int _Id;
        private string _Nom;
        private int _Prix;

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

        public int Prix
        {
            get { return _Prix; }
            set { _Prix = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models
{
    public class Talent
    {
        private int _Id;
        private string _Nom;
        private int _Limite;
        private string _Effet;
        private int _Id_Stat;

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

        public int Limite
        {
            get { return _Limite; }
            set { _Limite = value; }
        }

        public string Effet
        {
            get { return _Effet; }
            set { _Effet = value; }
        }

        public int Id_Stat
        {
            get { return _Id_Stat; }
            set { _Id_Stat = value; }
        }
    }
}

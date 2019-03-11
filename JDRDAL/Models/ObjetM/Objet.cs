using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models
{
    public class Objet
    {
        private int _Id;
        private string _Nom;
        private int _Encombrement;
        private int _Prix;
        private string _Effet;

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

        public int Encombrement
        {
            get { return _Encombrement; }
            set { _Encombrement = value; }
        }                

        public int Prix
        {
            get { return _Prix; }
            set { _Prix = value; }
        }        

        public string Effet
        {
            get { return _Effet; }
            set { _Effet = value; }
        }
    }
}

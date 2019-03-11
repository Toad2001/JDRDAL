using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Models
{
    public class B_Magie
    {
        private int _Id;
        private string _Nom;
        private string _Effet;
        private int _Id_EcoleMagie;
        private int _Id_RangMagie;

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

        public string Effet
        {
            get { return _Effet; }
            set { _Effet = value; }
        }        

        public int Id_EcoleMagie
        {
            get { return _Id_EcoleMagie; }
            set { _Id_EcoleMagie = value; }
        }        

        public int Id_RangMagie
        {
            get { return _Id_RangMagie; }
            set { _Id_RangMagie = value; }
        }
    }
}

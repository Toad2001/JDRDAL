using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Models
{
    public class B_Monstre
    {
        private int _Id;
        private string _Nom;
        private int? _Id_Ame;
        private int _Id_Rang;
        private int? _Id_Resistence;
        private int? _Id_Capacite;

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

        public int? Id_Ame
        {
            get { return _Id_Ame; }
            set { _Id_Ame = value; }
        }        

        public int Id_Rang
        {
            get { return _Id_Rang; }
            set { _Id_Rang = value; }
        }       

        public int? Id_Resistence
        {
            get { return _Id_Resistence; }
            set { _Id_Resistence = value; }
        }

        public int? Id_Capacite
        {
            get { return _Id_Capacite; }
            set { _Id_Capacite = value; }
        }
    }
}

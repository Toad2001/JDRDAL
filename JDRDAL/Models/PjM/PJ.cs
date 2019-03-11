using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models
{
    public class PJ
    {
        private int _Id;
        private string _Nom;
        private bool _Sexe;
        private bool _Blesse;
        private bool _Esquive;
        private bool _CoupPuissant;
        private int _Id_Race;
        private int _Id_Classe;
        private int _Id_Signe;

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

        public bool Sexe
        {
            get { return _Sexe; }
            set { _Sexe = value; }
        }

        public bool Blesse
        {
            get { return _Blesse; }
            set { _Blesse = value; }
        }

        public bool Esquive
        {
            get { return _Esquive; }
            set { _Esquive = value; }
        }

        public bool CoupPuissant
        {
            get { return _CoupPuissant; }
            set { _CoupPuissant = value; }
        }

        public int Id_Race
        {
            get { return _Id_Race; }
            set { _Id_Race = value; }
        }

        public int Id_Classe
        {
            get { return _Id_Classe; }
            set { _Id_Classe = value; }
        }

        public int Id_Signe
        {
            get { return _Id_Signe; }
            set { _Id_Signe = value; }
        }

        private int _ValeurD4;

        public int ValeurD4
        {
            get { return _ValeurD4; }
            set { _ValeurD4 = value; }
        }

        public PJ()
        {
        }

        public PJ(int id,string nom, bool sexe,bool blesse, bool esquive,bool coupPuissant,int id_Race,int id_Classe,int id_Signe)
        {
            Id = id;
            Nom = nom;
            Sexe = sexe;
            Blesse = blesse;
            Esquive = esquive;
            CoupPuissant = coupPuissant;
            Id_Race = id_Race;
            Id_Classe = id_Classe;
            Id_Signe = id_Signe;
        }         
    }            
}                 
                  
using JDRBusiness.Models;
using JDRBusiness.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDRapi.Models
{
    public class PJ
    {
        private B_RaceService raceService = new B_RaceService();
        private B_ClasseService classeService = new B_ClasseService();
        private B_SigneService signeService = new B_SigneService();

        #region Champ
        private int _Id;
        private string _Nom;
        private bool _Sexe;
        private bool _Blesse;
        private bool _Esquive;
        private bool _CoupPuissant;
        private int _Id_Race;
        private int _Id_Classe;
        private int _Id_Signe;
        private int _ValeurD4;
        private B_Race _Race;
        private B_Classe _Classe;
        private B_Signe _Signe;
        #endregion

        #region Propiriete

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

        private string _SexeNom;

        public string SexeNom
        {
            get
            {
                if (Sexe)
                {
                    return "M";
                }

                return "F";
            }
            set { _SexeNom = value; }
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

        public B_Race Race
        {
            get { return _Race ?? raceService.Get(Id_Race); }
            set { _Race = value; }
        }

        public B_Classe Classe
        {
            get { return _Classe ?? classeService.Get(Id_Classe); }
            set { _Classe = value; }
        }

        public B_Signe Signe
        {
            get { return _Signe ?? signeService.Get(Id_Signe); }
            set { _Signe = value; }
        }
        #endregion

    }
}
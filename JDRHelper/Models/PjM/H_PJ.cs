using JDRHelper.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JDRHelper.Models
{
    public class H_PJ
    {

        /// <summary>
        /// Lien Tuto DropdownList https://odetocode.com/blogs/scott/archive/2013/03/11/dropdownlistfor-with-asp-net-mvc.aspx
        /// </summary>

        #region Service
        private H_RaceService raceService = new H_RaceService();
        private H_ClasseService classeService = new H_ClasseService();
        private H_SigneService signeService = new H_SigneService();
        private De de = new De(4);
        #endregion

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
        private H_Race _Race;
        private H_Classe _Classe;
        private H_Signe _Signe;
        private List<H_PJDetails> _Details;
        private List<H_Equipement> _Equipement;
        private Dictionary<string, H_PJDetails> _DetailsFull;
        private Dictionary<string, H_PJDetails> _DetailsPerso;
        public int? SelectedRace { get; set; }
        public int? SelectedClasse { get; set; }
        public int? SelectedSigne { get; set; }
        #endregion

        #region Propiriete

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        [Required]
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        [Required]
        public bool Sexe
        {
            get { return _Sexe; }
            set { _Sexe = value; }
        }

        private string _SexeNom;

        public string SexeNom {
            get
            {
                if (Sexe)
                {
                    return "M";
                }

                return "F";
            }
            set { _SexeNom = value; } }

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

        public H_Race Race
        {
            get { return _Race ?? raceService.Get(Id_Race);}
            set { _Race = value; }
        }

        public H_Classe Classe
        {
            get { return _Classe ?? classeService.Get(Id_Classe); }
            set { _Classe = value; }
        }

        public H_Signe Signe
        {
            get { return _Signe ?? signeService.Get(Id_Signe); }
            set { _Signe = value; }
        }

        public IEnumerable<SelectListItem> RaceL
        {
            get { return new SelectList(raceService.Get(), nameof(Race.Id), nameof(Race.Nom)); }
        }

        public IEnumerable<SelectListItem> SigneL
        {
            get { return new SelectList(signeService.Get(), nameof(Signe.Id), nameof(Signe.Nom)); }
        }

        public IEnumerable<SelectListItem> ClasseL
        {
            get { return new SelectList(classeService.Get(), nameof(Classe.Id), nameof(Classe.Nom)); }
        }

        public int ValeurD4
        {
            get { return _ValeurD4 = de.Lancer(); }
            set { _ValeurD4 = value; }
        }

        public List<H_Equipement> Equipement
        {
            get { return _Equipement; }
            set { _Equipement = value; }
        }

        public List<H_PJDetails> Details
        {
            get { return _Details; }
            set { _Details = value; }
        }

        public Dictionary<string, H_PJDetails> DetailsFull
        {
            get { return _DetailsFull = _DetailsFull ?? GetDetailsFull(); }
            set { _DetailsFull = value; }
        }

        public Dictionary<string, H_PJDetails> DetailsPerso
        {
            get { return _DetailsPerso = _DetailsPerso ??  GetDetailsPerso(); }
            set { _DetailsPerso = value; }
        }

        private H_Details _Perception;

        public H_Details Perception
        {
            get { return GetPerception(); }
            set { _Perception = value; }
        }
#endregion

        #region Constructeurs
        public H_PJ()
        {
        }

        public H_PJ(int id, string nom, bool sexe, bool blesse, bool esquive, bool coupPuissant, int idRace, int idClasse, int IdSigne, int valeurD4, List<H_PJDetails> details)
        {
            Id = id;
            Nom = nom;
            Sexe = sexe;
            Blesse = blesse;
            Esquive = esquive;
            CoupPuissant = coupPuissant;
            Id_Race = idRace;
            Race = raceService.Get(Id_Race);
            Race.Details = raceService.GetAll(Id_Race).ToList();
            Id_Classe = idClasse;
            Classe = classeService.Get(Id_Classe);
            Id_Signe = IdSigne;
            Signe = signeService.Get(Id_Signe);
            ValeurD4 = valeurD4;
            Details = details;
        }
        #endregion

        #region Metodes
        private Dictionary<string,H_PJDetails> GetDetailsFull()
        {
            Dictionary<string, H_PJDetails> dico = new Dictionary<string, H_PJDetails>();

            foreach (H_PJDetails item in Details)
            {
                foreach (H_Details itemR in Race.Details)
                {
                    if (item.Nom == itemR.NomStat)
                    {
                        dico.Add(item.Nom, item);
                        dico[item.Nom].Valeur += itemR.ValeurStat;
                    }
                }
                foreach (H_Details itemC in Classe.Details)
                {
                    if (item.Nom == itemC.NomStat)
                    {
                        dico[item.Nom].Valeur += itemC.ValeurStat;
                    }
                }
            }
            return dico;
        }

        private Dictionary<string, H_PJDetails> GetDetailsPerso()
        {
            Dictionary<string, H_PJDetails> dico = new Dictionary<string, H_PJDetails>();

            foreach (H_PJDetails item in Details)
            {
                if (NotUse(item.Nom))
                {
                    dico.Add(item.Nom, item);
                }
            }
            return dico;
        }

        private bool NotUse(string nom)
        {
            foreach (var item in DetailsFull)
            {
                if (item.Key == nom)
                {
                    return false;
                }
            }
            return true;
        }

        private H_Details GetPerception()
        {
            foreach (var item in Race.Details)
            {
                if (item.NomStat == "Perception")
                {
                    return item;
                }
            }
            return null;
        }
        #endregion
    }
}
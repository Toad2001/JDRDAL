using JDRHelper.Services;
using JDRHelper.Services.ObjetS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRHelper.Models
{
    public class H_Equipement
    {
        private H_MatiereService matiereService = new H_MatiereService();
        private H_ArmeService armeService = new H_ArmeService();
        private H_ArmureService armureService = new H_ArmureService();
        private H_StyleService styleService = new H_StyleService();
        private H_EnchantementService enchantService = new H_EnchantementService();

        private int _Id;
        private int? _Id_Arme;
        private H_Arme _Arme;
        private int? _Id_Armure;
        private H_Armure _Armure;
        private int _Id_Matiere;
        private H_Matiere _Matiere;
        private int _Id_Style;
        private H_Style _Style;
        private int? _Id_Enchantement;
        private H_Enchantement _Enchantement;
        private Dictionary<string, int> _DetailsArme;
        private Dictionary<string, int> _DetailsArmure;


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int? Id_Arme
        {
            get { return _Id_Arme; }
            set { _Id_Arme = value; }
        }

        public H_Arme Arme
        {
            get { return _Arme = _Arme ?? armeService.Get((int)Id_Arme); }
            set { _Arme = value; }
        }

        public int? Id_Armure
        {
            get { return _Id_Armure; }
            set { _Id_Armure = value; }
        }

        public H_Armure Armure
        {
            get { return _Armure = _Armure ?? armureService.Get(Id_Armure); }
            set { _Armure = value; }
        }

        public int Id_Matiere
        {
            get { return _Id_Matiere; }
            set { _Id_Matiere = value; }
        }

        public H_Matiere Matiere
        {
            get { return _Matiere = _Matiere ?? matiereService.Get(Id_Matiere); }
            set { _Matiere = value; }
        }

        public int Id_Style
        {
            get { return _Id_Style; }
            set { _Id_Style = value; }
        }

        public H_Style Style
        {
            get { return _Style = _Style ?? styleService.Get(Id_Style); }
            set { _Style = value; }
        }

        public int? Id_Enchantement
        {
            get { return _Id_Enchantement; }
            set { _Id_Enchantement = value; }
        }

        public H_Enchantement Enchantement
        {
            //get { return _Enchantement = Id_Enchantement == null ? null : enchantService.Get((int)Id_Enchantement); }
            get { return _Enchantement = _Enchantement ?? enchantService.Get((int)Id_Enchantement); }

            set { _Enchantement = value; }
        }

        public Dictionary<string, int> DetailsArme
        {
            get { return _DetailsArme = _DetailsArme ?? GetDetailsArme(); }
            set { _DetailsArme = value; }
        }

        public Dictionary<string, int> DetailsArmure
        {
            get { return _DetailsArmure = _DetailsArmure ?? GetDetailsArmure(); }
            set { _DetailsArmure = value; }
        }

        private Dictionary<string, int> GetDetailsArme()
        {
            Dictionary<string, int> dico = new Dictionary<string, int>();
            
            foreach (H_Details item in Arme.Details)
            {
                foreach (H_Details itemM in Matiere.Details)
                {
                    if (item.NomStat == itemM.NomStat)
                    {
                        dico.Add(item.NomStat, item.ValeurStat + itemM.ValeurStat);
                    }
                }
                if (Id_Enchantement != null)
                {
                    foreach (H_Details itemE in Enchantement.Details)
                    {
                        if (item.NomStat == itemE.NomStat)
                        {
                            dico[item.NomStat] += itemE.ValeurStat;
                        }
                    }
                }
            }
            return dico;
        }

        private Dictionary<string, int> GetDetailsArmure()
        {
            Dictionary<string, int> dico = new Dictionary<string, int>();

            string nom;
            int val;
            string nom2;
            int val2;

            foreach (H_Details item in Armure.Details)
            {
                foreach (H_Details itemM in Matiere.Details)
                {
                    if (item.NomStat == itemM.NomStat)
                    {
                        dico.Add(item.NomStat, item.ValeurStat + itemM.ValeurStat);
                        nom = item.NomStat;
                        val = dico[item.NomStat];
                    }

                    if (item.NomStat == "Défense" && itemM.NomStat == "Dégats")
                    {
                        dico.Add(item.NomStat, item.ValeurStat + itemM.ValeurStat);
                    }

                }
                if (Id_Enchantement != null)
                {
                    foreach (H_Details itemE in Enchantement.Details)
                    {
                        if (item.NomStat == itemE.NomStat)
                        {
                            dico[item.NomStat] += itemE.ValeurStat;
                            nom2 = item.NomStat;
                            val2 = dico[item.NomStat];
                        }
                    }
                }
            }
            return dico;
        }
    }
}

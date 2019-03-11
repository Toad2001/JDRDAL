using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models.ObjetM
{
    public class Equipement
    {
        private int _Id;
        private int? _Id_Arme;
        private int? _Id_Armure;
        private int _Id_Matiere;
        private int _Id_Style;
        private int? _Id_Enchantement;

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

        public int? Id_Armure
        {
            get { return _Id_Armure; }
            set { _Id_Armure = value; }
        }

        public int Id_Matiere
        {
            get { return _Id_Matiere; }
            set { _Id_Matiere = value; }
        }

        public int Id_Style
        {
            get { return _Id_Style; }
            set { _Id_Style = value; }
        }

        public int? Id_Enchantement
        {
            get { return _Id_Enchantement; }
            set { _Id_Enchantement = value; }
        }

        public Equipement()
        {
        }

        public Equipement(int id, int id_arme, int id_armure, int id_matiere, int id_style, int id_enchantement )
        {
            Id = id;
            Id_Arme = id_arme;
            Id_Armure = id_armure;
            Id_Matiere = id_matiere;
            Id_Style = id_style;
            Id_Enchantement = id_enchantement;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Models
{
    public class B_Equipement
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models
{
    public class Arme
    {
        private int _Id;
        private string _Nom;        
        private int _Id_Enchantement;
        private int _Id_Matiere;
        private int _Id_Style;
        private int _Id_Typearme;
        private int _Malus;
        private bool _TailleArme;

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

        public int Id_TypeArme
        {
            get { return _Id_Typearme; }
            set { _Id_Typearme = value; }
        }

        public int Id_Enchantement
        {
            get { return _Id_Enchantement; }
            set { _Id_Enchantement = value; }
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

        public int Malus
        {
            get { return _Malus; }
            set { _Malus = value; }
        }

        public bool TailleArme
        {
            get { return _TailleArme; }
            set { _TailleArme = value; }
        }
    }
}

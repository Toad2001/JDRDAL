using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRHelper.Models.Intermediaire
{
    public class H_Enchantement_Stat
    {
        private int _Id;
        private int _Id_Enchantement;
        private int _Id_Stat;
        private int _Valeur;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }        

        public int Id_Enchantement
        {
            get { return _Id_Enchantement; }
            set { _Id_Enchantement = value; }
        }        

        public int Id_Stat
        {
            get { return _Id_Stat; }
            set { _Id_Stat = value; }
        }        

        public int Valeur
        {
            get { return _Valeur; }
            set { _Valeur = value; }
        }
    }
}

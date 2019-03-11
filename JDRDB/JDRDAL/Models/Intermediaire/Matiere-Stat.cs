using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models.Intermediaire
{
    public class Matiere_Stat
    {
        private int _Id;
        private int _Id_Matiere;
        private int _Id_Stat;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }        

        public int Id_Matiere
        {
            get { return _Id_Matiere; }
            set { _Id_Matiere = value; }
        }        

        public int Id_Stat
        {
            get { return _Id_Stat; }
            set { _Id_Stat = value; }
        }
    }
}

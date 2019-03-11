using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Models
{
    public class B_Matiere
    {
        private int _Id;
        private string _Nom;
        private bool _Arme;
        private bool _ArmureLourd;
        private bool _ArmureLegere;

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

        public bool Arme
        {
            get { return _Arme; }
            set { _Arme = value; }
        }

        public bool ArmureLourd
        {
            get { return _ArmureLourd; }
            set { _ArmureLourd = value; }
        }

        public bool ArmureLegere
        {
            get { return _ArmureLegere; }
            set { _ArmureLegere = value; }
        }

        public List <B_Details> Details { get; set; }
    }
}

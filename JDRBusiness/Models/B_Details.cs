using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Models
{
    public class B_Details // pout-on toujours utiliser la même?
    {
        private string _nomStat;
        private int _valeurStat;

        public string NomStat { get => _nomStat; set => _nomStat = value; }
        public int ValeurStat { get => _valeurStat; set => _valeurStat = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDRHelper.Models
{
    public class H_Details
    {
        private string _nomStat;
        private int _valeurStat;

        public string NomStat { get => _nomStat; set => _nomStat = value; }
        public int ValeurStat { get => _valeurStat; set => _valeurStat = value; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDRHelper.Models.ViewModel
{
    public class UpdateStatViewModel
    {
        public int Id { get; set; }
        private string _Nom;

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        private int _Valeur;

        public int Valeur
        {
            get { return _Valeur; }
            set { _Valeur = value; }
        }
    }
}
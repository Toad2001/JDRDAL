using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRDAL.Models
{
    public class Armure
    {
        private int _Id;
        private string _Nom;        
        private int _Id_Enchantement;
        private int _Id_Matiere;
        private int _Id_Style;
        private int _Id_TypeArmure;

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

        //public int Encombrement
        //{
        //    get { return _Encombrement; }
        //    set { _Encombrement = value; }
        //}        

        //public int Valeur
        //{
        //    get { return _Valeur; }
        //    set { _Valeur = value; }
        //}        

        //public int Protection
        //{
        //    get { return _Protection; }
        //    set { _Protection = value; }
        //}        

        //public bool Type
        //{
        //    get { return _Type; }
        //    set { _Type = value; }
        //}        

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

        public int Id_TypeArmure
        {
            get { return _Id_TypeArmure; }
            set { _Id_TypeArmure = value; }
        }
    }
}

using JDRHelper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRHelper.Models
{
    public class H_Race
    {

        private H_RaceService raceService = new H_RaceService();

        private int _Id;
        private string _Nom;
        private int _Id_Province;
        private int? _Id_Resistence;
        private int _Id_Capacite1;
        private int _Id_Capacite2;

        private List<H_Details> _Details;

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

        public int Id_Province
        {
            get { return _Id_Province; }
            set { _Id_Province = value; }
        }

        public int? Id_Resistence
        {
            get { return _Id_Resistence; }
            set { _Id_Resistence = value; }
        }

        public int Id_Capacite1
        {
            get { return _Id_Capacite1; }
            set { _Id_Capacite1 = value; }
        }

        public int Id_Capacite2
        {
            get { return _Id_Capacite2; }
            set { _Id_Capacite2 = value; }
        }

        public List<H_Details> Details
        {
            get { return _Details; }
            set { _Details = value; }
        }
    }
}

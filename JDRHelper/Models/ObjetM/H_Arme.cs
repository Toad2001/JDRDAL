using JDRHelper.Services.ObjetS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRHelper.Models
{
    public class H_Arme
    {
        private H_TypeArmeService typeService = new H_TypeArmeService();

        private int _Id;
        private string _Nom;        
        private int _Id_Typearme;

        private H_TypeArme _Type;
        private int _Malus;
        private bool _TailleArme;
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

        public int Id_TypeArme
        {
            get { return _Id_Typearme; }
            set { _Id_Typearme = value; }
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

        public H_TypeArme Type
        {
            get { return _Type = _Type ?? typeService.Get(Id_TypeArme); ; }
            set { _Type = value; }
        }

        public List<H_Details> Details
        {
            get { return _Details; }
            set { _Details = value; }
        }

    }
}

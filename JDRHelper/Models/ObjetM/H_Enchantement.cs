using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRHelper.Models
{
    public class H_Enchantement
    {
        private int _Id;
        private string _Nom;
        private string _Effet;
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

        public string Effet
        {
            get { return _Effet; }
            set { _Effet = value; }
        }

        public List<H_Details> Details
        {
            get { return _Details; }
            set { _Details = value; }
        }

    }
}

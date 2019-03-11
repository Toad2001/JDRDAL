using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Models
{
    public class B_PJ_User
    {
        private int _id;
        private int _Id_PJ;
        private int _Id_User;

        public int Id { get => _id; set => _id = value; }

        public int Id_PJ
        {
            get { return _Id_PJ; }
            set { _Id_PJ = value; }
        }

        public int Id_User
        {
            get { return _Id_User; }
            set { _Id_User = value; }
        }
    }
}

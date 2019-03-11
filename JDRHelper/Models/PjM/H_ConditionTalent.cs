using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRHelper.Models
{
    public class H_ConditionTalent
    {
        private int _Id;
        private string _Condition;
        private int _Id_Talent;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }        

        public string Condition
        {
            get { return _Condition; }
            set { _Condition = value; }
        }        

        public int Id_Talent
        {
            get { return _Id_Talent; }
            set { _Id_Talent = value; }
        }
    }
}

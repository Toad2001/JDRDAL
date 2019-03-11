using JDRBusiness.Models;
using JDRBusiness.Services.MonstreS;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.MonstreS
{
    public class H_MonstreService
    {
        private B_MonstreService repo = new B_MonstreService();

        public H_Monstre Get(int id)
        {
            return Mapper<B_Monstre, H_Monstre>.Map(repo.Get(id));
        }
    }
}

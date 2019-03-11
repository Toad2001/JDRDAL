using JDRBusiness.Models;
using JDRBusiness.Services;
using JDRBusiness.Services.StatS;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.StatS
{
    public class H_StatService
    {
        private B_StatService repo = new B_StatService();

        public H_Stat Get(int id)
        {
            return Mapper<B_Stat, H_Stat>.Map(repo.Get(id));
        }
    }
}

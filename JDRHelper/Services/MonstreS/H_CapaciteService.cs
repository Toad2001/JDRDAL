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
    public class H_CapaciteService
    {
        private B_CapaciteService repo = new B_CapaciteService();

        public H_Capacite Get(int id)
        {
            return Mapper<B_Capacite, H_Capacite>.Map(repo.Get(id));
        }
    }
}

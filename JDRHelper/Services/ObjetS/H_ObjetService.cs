using JDRBusiness.Models;
using JDRBusiness.Services.ObjetS;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.ObjetS
{
    public class H_ObjetService
    {
        private B_ObjetService repo = new B_ObjetService();

        public H_Objet Get(int id)
        {
            return Mapper<B_Objet, H_Objet>.Map(repo.Get(id));
        }
    }
}

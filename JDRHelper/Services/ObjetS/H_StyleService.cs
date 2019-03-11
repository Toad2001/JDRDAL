using JDRBusiness.Models;
using JDRBusiness.Services.ObjetS;
using JDRHelper.Mappers;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.ObjetS
{
    public class H_StyleService
    {
        private B_StyleService repo = new B_StyleService();

        public H_Style Get(int id)
        {
            return Mapper<B_Style, H_Style>.Map(repo.Get(id));
        }
    }
}

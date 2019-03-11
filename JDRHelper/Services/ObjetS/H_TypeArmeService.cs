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
    public class H_TypeArmeService
    {
        private B_TypeArmeService repo = new B_TypeArmeService();

        public H_TypeArme Get(int id)
        {
            return Mapper<B_TypeArme, H_TypeArme>.Map(repo.Get(id));
        }
    }
}

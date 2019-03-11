using JDRBusiness.Models;
using JDRBusiness.Services;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services
{
    public class H_SigneService
    {
        private B_SigneService signeR = new B_SigneService();

        public IEnumerable<H_Signe> Get()
        {
            return signeR.Get().Select(m => Mapper<B_Signe, H_Signe>.Map(m));
        }

        public H_Signe Get(int id)
        {
            return Mapper<B_Signe, H_Signe>.Map(signeR.Get(id));
        }
    }
}


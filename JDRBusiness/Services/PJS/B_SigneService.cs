using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories.PJR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services
{
    public class B_SigneService
    {
        private SigneRepository signeR = new SigneRepository();

        public IEnumerable<B_Signe> Get()
        {
            return signeR.GetAll().Select(m => Mapper<Signe, B_Signe>.Map(m));
        }

        public B_Signe Get(int id)
        {
            return Mapper<Signe, B_Signe>.Map(signeR.Get(id));
        }
    }
}


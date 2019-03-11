using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories.PNJR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services.PNJS
{
    public class B_PNJService
    {
        private PNJRepository repo = new PNJRepository();

        public B_PNJ Get(int id)
        {
            return Mapper<PNJ, B_PNJ>.Map(repo.Get(id));
        }
    }
}

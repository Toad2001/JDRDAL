using JDRBusiness.Models;
using JDRBusiness.Services.PNJS;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.PNJS
{
    public class H_PNJService
    {
        private B_PNJService repo = new B_PNJService();

        public H_PNJ Get(int id)
        {
            return Mapper<B_PNJ, H_PNJ>.Map(repo.Get(id));
        }
    }
}

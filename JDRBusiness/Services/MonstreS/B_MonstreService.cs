using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories.MonstreR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services.MonstreS
{
    public class B_MonstreService
    {
        private MonstreRepository repo = new MonstreRepository();

        public B_Monstre Get(int id)
        {
            return Mapper<Monstre, B_Monstre>.Map(repo.Get(id));
        }
    }
}

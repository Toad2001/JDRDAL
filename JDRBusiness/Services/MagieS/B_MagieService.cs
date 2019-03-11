using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services.MagieS
{
    public class B_MagieService
    {
        private MagieRepository repo = new MagieRepository();

        public B_Magie Get(int id)
        {
            return Mapper<Magie, B_Magie>.Map(repo.Get(id));
        }
    }
}

using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories.Magie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services.MagieS
{
    public class B_AmeService
    {
        private AmeRepository repo = new AmeRepository();

        public B_Ame Get(int id)
        {
            return Mapper<Ame, B_Ame>.Map(repo.Get(id));
        }
    }
}

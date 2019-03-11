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
    public class B_EcoleMagieService
    {
        private EcoleMagieRepository repo = new EcoleMagieRepository();

        public B_EcoleMagie Get(int id)
        {
            return Mapper<EcoleMagie, B_EcoleMagie>.Map(repo.Get(id));
        }
    }
}

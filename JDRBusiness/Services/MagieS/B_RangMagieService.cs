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
    public class B_RangMagieService
    {
        private RangMagieRepository repo = new RangMagieRepository();

        public B_RangMagie Get(int id)
        {
            return Mapper<RangMagie, B_RangMagie>.Map(repo.Get(id));
        }
    }
}

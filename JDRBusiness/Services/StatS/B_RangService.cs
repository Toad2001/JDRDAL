using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories.Stat;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services.StatS
{
    public class B_RangService
    {
        private RangRepository repo = new RangRepository();

        public B_Rang Get(int id)
        {
            return Mapper<Rang, B_Rang>.Map(repo.Get(id));
        }
    }
}

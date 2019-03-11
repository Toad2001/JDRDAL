using JDRBusiness.Models;
using JDRBusiness.Services.StatS;
using JDRHelper.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.StatS
{
    public class H_RangService
    {
        private B_RangService repo = new B_RangService();

        public H_Rang Get(int id)
        {
            return Mapper<B_Rang, H_Rang>.Map(repo.Get(id));
        }
    }
}

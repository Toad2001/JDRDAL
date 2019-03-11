using JDRBusiness.Models;
using JDRBusiness.Services.MagieS;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.MagieS
{
    public class H_MagieService
    {
        private B_MagieService repo = new B_MagieService();

        public H_Magie Get(int id)
        {
            return Mapper<B_Magie, H_Magie>.Map(repo.Get(id));
        }
    }
}

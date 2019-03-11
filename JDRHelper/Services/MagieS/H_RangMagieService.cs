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
    public class H_RangMagieService
    {
        private B_RangMagieService repo = new B_RangMagieService();

        public H_RangMagie Get(int id)
        {
            return Mapper<B_RangMagie, H_RangMagie>.Map(repo.Get(id));
        }
    }
}

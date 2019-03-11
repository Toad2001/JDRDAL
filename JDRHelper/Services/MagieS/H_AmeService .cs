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
    public class H_AmeService
    {
        private B_AmeService repo = new B_AmeService();

        public H_Ame Get(int id)
        {
            return Mapper<B_Ame, H_Ame>.Map(repo.Get(id));
        }
    }
}

using JDRBusiness.Models;
using JDRBusiness.Services.PJS;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.PJS
{
    public class H_TalentService
    {
        private B_TalentService repo = new B_TalentService();

        public H_Talent Get(int id)
        {
            return Mapper<B_Talent, H_Talent>.Map(repo.Get(id));
        }
    }
}

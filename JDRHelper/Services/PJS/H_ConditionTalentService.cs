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
    public class H_ConditionTalentService
    {
        private B_ConditionTalentService repo = new B_ConditionTalentService();

        public H_ConditionTalent Get(int id)
        {
            return Mapper<B_ConditionTalent, H_ConditionTalent>.Map(repo.Get(id));
        }
    }
}

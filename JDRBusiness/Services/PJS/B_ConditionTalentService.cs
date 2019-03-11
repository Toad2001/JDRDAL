using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories.PJR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services.PJS
{
    public class B_ConditionTalentService
    {
        private ConditionTalentRepository repo = new ConditionTalentRepository();

        public B_ConditionTalent Get(int id)
        {
            return Mapper<ConditionTalent, B_ConditionTalent>.Map(repo.Get(id));
        }
    }
}

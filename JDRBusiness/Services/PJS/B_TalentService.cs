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
    public class B_TalentService
    {
        private TalentRepository repo = new TalentRepository();

        public B_Talent Get(int id)
        {
            return Mapper<Talent, B_Talent>.Map(repo.Get(id));
        }
    }
}

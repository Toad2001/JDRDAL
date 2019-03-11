using JDRBusiness.Models;
using JDRBusiness.Services.ObjetS;
using JDRHelper.Mappers;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.ObjetS
{
    public class H_ArmureService
    {
        private B_ArmureService repo = new B_ArmureService();

        public IEnumerable<H_Details> GetAll(int id)
        {
            H_Armure item = Mapper<B_Armure, H_Armure>.Map(repo.Get(id));
            return item.Details = (repo.GetAll(item.Id).ToList()).ToHelper();
        }

        public H_Armure Get(int? id)
        {
            if (id != null)
            return Mapper<B_Armure, H_Armure>.Map(repo.Get((int)id));

            return null;
        }
    }
}

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
    public class H_ArmeService
    {
        private B_ArmeService repo = new B_ArmeService();

        public IEnumerable<H_Details> GetAll(int id)
        {
            H_Arme item = Mapper<B_Arme, H_Arme>.Map(repo.Get(id));
            return item.Details = (repo.GetAll(item.Id).ToList()).ToHelper();
        }

        public H_Arme Get(int id)
        {
            return Mapper<B_Arme, H_Arme>.Map(repo.Get(id));
        }
    }
}

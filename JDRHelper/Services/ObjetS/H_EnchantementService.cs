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
    public class H_EnchantementService
    {
        private B_EnchantementService repo = new B_EnchantementService();

        public IEnumerable<H_Details> GetAll(int id)
        {
            H_Enchantement item = Mapper<B_Enchantement, H_Enchantement>.Map(repo.Get(id));
            return item.Details = (repo.GetAll(item.Id).ToList()).ToHelper();
        }

        public H_Enchantement Get(int id)
        {
            return Mapper<B_Enchantement, H_Enchantement>.Map(repo.Get(id));
        }
    }
}

using JDRBusiness.Models;
using JDRBusiness.Services.LieuProvinceS;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.LieuProvinceS
{
    public class H_LieuService
    {
        private B_LieuService repo = new B_LieuService();

        public H_Lieu Get(int id)
        {
            return Mapper<B_Lieu, H_Lieu>.Map(repo.Get(id));
        }
    }
}

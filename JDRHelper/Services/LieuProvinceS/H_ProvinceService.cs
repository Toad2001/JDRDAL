using JDRBusiness.Models;
using JDRBusiness.Services.LieuProvinceS;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.ProvinceProvinceS
{
    public class H_ProvinceService
    {
        private B_ProvinceService repo = new B_ProvinceService();

        public H_Province Get(int id)
        {
            return Mapper<B_Province, H_Province>.Map(repo.Get(id));
        }
    }
}

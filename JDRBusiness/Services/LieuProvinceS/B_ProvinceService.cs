using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories.Lieu_Province;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services.LieuProvinceS
{
    public class B_ProvinceService
    {
        private ProvinceRepository repo = new ProvinceRepository();

        public B_Province Get(int id)
        {
            return Mapper<Province, B_Province>.Map(repo.Get(id));
        }
    }
}

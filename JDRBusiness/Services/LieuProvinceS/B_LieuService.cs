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
    public class B_LieuService
    {
        private LieuRepository repo = new LieuRepository();

        public B_Lieu Get(int id)
        {
            return Mapper<Lieu, B_Lieu>.Map(repo.Get(id));
        }
    }
}

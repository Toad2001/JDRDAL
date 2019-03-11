using JDRBusiness.Models;
using JDRBusiness.Services.MagieS;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.MagieS
{
    public class H_EcoleMagieService
    {
        private B_EcoleMagieService repo = new B_EcoleMagieService();

        public H_EcoleMagie Get(int id)
        {
            return Mapper<B_EcoleMagie, H_EcoleMagie>.Map(repo.Get(id));
        }
    }
}

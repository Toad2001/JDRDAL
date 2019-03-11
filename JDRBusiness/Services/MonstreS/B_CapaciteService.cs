using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories.MonstreR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services.MonstreS
{
    public class B_CapaciteService
    {
        private CapaciteRepository repo = new CapaciteRepository();

        public B_Capacite Get(int id)
        {
            return Mapper<Capacite, B_Capacite>.Map(repo.Get(id));
        }
    }
}

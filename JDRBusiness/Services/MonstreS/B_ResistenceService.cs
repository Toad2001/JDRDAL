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
    public class B_ResistenceService
    {
        private ResistenceRepository repo = new ResistenceRepository();

        public B_Resistence Get(int id)
        {
            return Mapper<Resistence, B_Resistence>.Map(repo.Get(id));
        }
    }
}

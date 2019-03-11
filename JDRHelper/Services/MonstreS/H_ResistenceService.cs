using JDRBusiness.Models;
using JDRBusiness.Services.MonstreS;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.MonstreS
{
    public class H_ResistenceService
    {
        private B_ResistenceService repo = new B_ResistenceService();

        public H_Resistence Get(int id)
        {
            return Mapper<B_Resistence, H_Resistence>.Map(repo.Get(id));
        }
    }
}

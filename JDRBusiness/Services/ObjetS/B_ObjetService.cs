using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services.ObjetS
{
    public class B_ObjetService
    {
        private ObjetRepository repo = new ObjetRepository();

        public B_Objet Get(int id)
        {
            return Mapper<Objet, B_Objet>.Map(repo.Get(id));
        }
    }
}

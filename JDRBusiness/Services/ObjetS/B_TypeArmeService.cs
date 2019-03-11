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
    public class B_TypeArmeService
    {
        private TypeArmeRepository repo = new TypeArmeRepository();

        public B_TypeArme Get(int id)
        {
            return Mapper<TypeArme, B_TypeArme>.Map(repo.Get(id));
        }
    }
}

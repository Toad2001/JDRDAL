using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories.PNJR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services.PNJS
{
    public class B_ClassePNJService
    {
        private ClassePNJRepository repo = new ClassePNJRepository();

        public B_ClassePNJ Get(int id)
        {
            return Mapper<ClassePNJ, B_ClassePNJ>.Map(repo.Get(id));
        }
    }
}

using JDRBusiness.Models;
using JDRBusiness.Services.PNJS;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.PNJS
{
    public class H_ClassePNJService
    {
        private B_ClassePNJService repo = new B_ClassePNJService();

        public H_ClassePNJ Get(int id)
        {
            return Mapper<B_ClassePNJ, H_ClassePNJ>.Map(repo.Get(id));
        }
    }
}

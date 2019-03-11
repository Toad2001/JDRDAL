using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.MappeurGeneric;
using ToolBox.Pattern.Locator;

namespace JDRBusiness.Services.ObjetS
{
    public class B_StyleService
    {
        private StyleRepository repo = new StyleRepository();

        public B_Style Get(int id)
        {
            return Mapper<Style, B_Style>.Map(repo.Get(id));
        }
    }
}

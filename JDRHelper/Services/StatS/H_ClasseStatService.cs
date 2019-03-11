using JDRBusiness.Models;
using JDRBusiness.Services.StatS;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.StatS
{
    public class H_ClasseStatService
    {
        private B_ClasseStatService repo = new B_ClasseStatService();

        public IEnumerable<H_ClasseStat> Get()
        {
            return repo.Get().Select(u => Mapper<B_ClasseStat, H_ClasseStat>.Map(u));
        }

        public H_ClasseStat Get(int id)
        {
            return Mapper<B_ClasseStat, H_ClasseStat>.Map(repo.Get(id));
        }
    }
}

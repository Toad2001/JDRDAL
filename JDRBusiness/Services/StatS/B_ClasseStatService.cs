using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories.Stat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services.StatS
{
    public class B_ClasseStatService
    {
        private CLasseStatRepository repo = new CLasseStatRepository();

        public IEnumerable<B_ClasseStat> Get()
        {
            return repo.GetAll().Select(u => Mapper<ClasseStat, B_ClasseStat>.Map(u));
        }

        public B_ClasseStat Get(int id)
        {
            return Mapper<ClasseStat, B_ClasseStat>.Map(repo.Get(id));
        }
    }
}

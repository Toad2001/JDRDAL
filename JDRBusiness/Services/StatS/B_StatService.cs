using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories.Stat;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services.StatS
{
    public class B_StatService
    {
        private StatRepository repo = new StatRepository();

        public B_Stat Get(int id)
        {
            return Mapper<Stat, B_Stat>.Map(repo.Get(id));
        }
    }
}

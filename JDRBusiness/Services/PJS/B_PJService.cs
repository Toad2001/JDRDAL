//using JDRBusiness.Mappers;
using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories.PJR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.MappeurGeneric;
using ToolBox.Pattern.Locator;
using ToolBox.Pattern.Repository;


namespace JDRBusiness.Services
{
    public class B_PJService : IRepository<int, B_PJ>
    {
        private PJRepository pJR = new PJRepository();

        public IEnumerable<B_PJDetails> GetAll(int id)
        {
            Command cmd = new Command("SelectStat", true);

            cmd.AddParameter("IdPJ", id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, bp => new B_PJDetails() { Id = (int)bp["Id"], Nom = (string)bp["Nom"], Valeur = (int)bp["Valeur"] });
        }        

        public IEnumerable<B_PJ> Get()
        {
            return pJR.Get().Select(pj => Mapper<PJ, B_PJ>.Map(pj));
        }

        public B_PJ Get(int id)
        {
            return Mapper<PJ, B_PJ>.Map(pJR.Get(id));
        }

        public B_PJ Insert(B_PJ entity)
        {
            return Mapper<PJ, B_PJ>.Map(pJR.Insert(Mapper<B_PJ, PJ>.Map(entity)));
        }

        public bool Update(int id, B_PJ entity)
        {
            return pJR.Update(id, Mapper<B_PJ, PJ>.Map(entity));
        }

        public bool Delete(int id)
        {
            return pJR.Delete(id);
        }
    }
}

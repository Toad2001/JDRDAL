//using JDRBusiness.Mappers;
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
using ToolBox.Pattern.Repository;


namespace JDRBusiness.Services
{
    public class B_MatiereService : IRepository<int, B_Matiere>
    {
        private MatiereRepository matiereR = new MatiereRepository();

        public IEnumerable<B_Details> GetAll(int id)
        {
            Command cmd = new Command("SELECT S.Nom , PS.Valeur FROM [Matiere-Stat] PS JOIN Stat S ON PS.Id_Stat = S.Id WHERE PS.Id_Matiere = @IdMatiere");

            cmd.AddParameter("IdMatiere", id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, m => new B_Details() { NomStat = (string)m["Nom"], ValeurStat = (int)m["Valeur"] });
        }

        public IEnumerable<B_Matiere> Get()
        {
            return matiereR.Get().Select(m => Mapper<Matiere, B_Matiere>.Map(m));
        }

        public B_Matiere Get(int id)
        {
            return Mapper<Matiere, B_Matiere>.Map(matiereR.Get(id));
        }

        public B_Matiere Insert(B_Matiere entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, B_Matiere entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

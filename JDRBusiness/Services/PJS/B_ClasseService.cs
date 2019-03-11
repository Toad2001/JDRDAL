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

namespace JDRBusiness.Services
{
    public class B_ClasseService
    {
        private ClasseRepository classeR = new ClasseRepository();
        public IEnumerable<B_Details> GetAll(int id)
        {
            Command cmd = new Command("SELECT S.Nom , CS.Valeur FROM [Classe-Stat] CS JOIN Stat S ON CS.Id_Stat = S.Id WHERE CS.Id_Classe = @IdClasse");

            cmd.AddParameter("IdClasse", id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, m => new B_Details() { NomStat = (string)m["Nom"], ValeurStat = (int)m["Valeur"] });
        }

        public IEnumerable<B_Classe> Get()
        {
            return classeR.GetAll().Select(m => Mapper<Classe, B_Classe>.Map(m));
        }

        public B_Classe Get(int id)
        {
            return Mapper<Classe, B_Classe>.Map(classeR.Get(id));
        }
    }
}

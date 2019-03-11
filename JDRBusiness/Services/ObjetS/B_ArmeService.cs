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
    public class B_ArmeService
    {
        public IEnumerable<B_Details> GetAll(int id)
        {
            Command cmd = new Command("SELECT S.Nom , PS.Valeur FROM [Arme-Stat] PS JOIN Stat S ON PS.Id_Stat = S.Id WHERE PS.Id_Arme = @IdArme");

            cmd.AddParameter("IdArme", id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, m => new B_Details() { NomStat = (string)m["Nom"], ValeurStat = (int)m["Valeur"] });
        }

        private ArmeRepository repo = new ArmeRepository();

        public B_Arme Get(int id)
        {
            return Mapper<Arme, B_Arme>.Map(repo.Get(id));
        }
    }
}

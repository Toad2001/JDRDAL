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
    public class B_ArmureService
    {
        private ArmureRepository repo = new ArmureRepository();


        public IEnumerable<B_Details> GetAll(int id)
        {
            Command cmd = new Command("SELECT S.Nom , PS.Valeur FROM [Armure-Stat] PS JOIN Stat S ON PS.Id_Stat = S.Id WHERE PS.Id_Armure = @Id");

            cmd.AddParameter("Id", id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, m => new B_Details() { NomStat = (string)m["Nom"], ValeurStat = (int)m["Valeur"] });
        }

        public B_Armure Get(int id)
        {
            return Mapper<Armure, B_Armure>.Map(repo.Get(id));
        }
    }
}

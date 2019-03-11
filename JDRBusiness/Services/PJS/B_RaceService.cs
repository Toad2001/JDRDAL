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

namespace JDRBusiness.Services
{
    public class B_RaceService
    {
        private RaceRepository raceR = new RaceRepository();
        public IEnumerable<B_Details> GetAll(int id)
        {
            Command cmd = new Command("SELECT S.Nom , RS.Valeur FROM [Race-Stat] RS JOIN Stat S ON RS.Id_Stat = S.Id WHERE RS.Id_Race = @IdRace");

            cmd.AddParameter("IdRace", id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, m => new B_Details() { NomStat = (string)m["Nom"], ValeurStat = (int)m["Valeur"] });
        }

        public IEnumerable<B_Race> Get()
        {
            return raceR.GetAll().Select(m => Mapper<Race, B_Race>.Map(m));
        }

        public B_Race Get(int id)
        {
            return Mapper<Race, B_Race>.Map(raceR.Get(id));
        }
    }
}

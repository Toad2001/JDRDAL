using JDRDAL.Mappers;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories
{
    public class RaceRepository
    {
        public IEnumerable<Race> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Race");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToRace());
        }

        public Race Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Race WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToRace()).FirstOrDefault();
        }
    }
}

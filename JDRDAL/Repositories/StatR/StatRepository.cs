using M = JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;
using JDRDAL.Mappers;

namespace JDRDAL.Repositories.Stat
{
    public class StatRepository
    {
        public IEnumerable<M.Stat> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Stat");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToStat());
        }

        public M.Stat Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Stat WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToStat()).FirstOrDefault();
        }
    }
}

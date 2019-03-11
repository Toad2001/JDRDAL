using JDRDAL.Mappers;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.Stat
{
    public class RangRepository
    {
        public IEnumerable<Rang> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Rang");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToRang());
        }

        public Rang Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Rang WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToRang()).FirstOrDefault();
        }
    }
}

using JDRDAL.Mappers;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.PNJR
{
    public class PNJRepository
    {
        public IEnumerable<PNJ> GetAll()
        {
            Command cmd = new Command("SELECT * FROM PNJ");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToPNJ());
        }

        public PNJ Get(int id)
        {
            Command cmd = new Command("SELECT * FROM PNJ WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToPNJ()).FirstOrDefault();
        }
    }
}

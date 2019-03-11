using M=JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;
using JDRDAL.Mappers;

namespace JDRDAL.Repositories
{
    public class MagieRepository
    {
        public IEnumerable<M.Magie> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Magie");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new M.Magie());
        }

        public M.Magie Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Magie WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToMagie()).FirstOrDefault();
        }
    }
}

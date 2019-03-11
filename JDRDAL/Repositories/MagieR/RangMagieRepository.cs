using JDRDAL.Mappers;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.Magie
{
    public class RangMagieRepository
    {

        public IEnumerable<RangMagie> GetAll()
        {
            Command cmd = new Command("SELECT * FROM RangMagie");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new RangMagie());
        }

        public RangMagie Get(int id)
        {
            Command cmd = new Command("SELECT * FROM RangMagie WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToRangMagie()).FirstOrDefault();
        }
    }
}

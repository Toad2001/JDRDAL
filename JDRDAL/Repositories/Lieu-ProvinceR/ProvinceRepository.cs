using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.Lieu_Province
{
    public class ProvinceRepository
    {
        public IEnumerable<Province> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Province");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Province());
        }

        public Province Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Province WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Province()).FirstOrDefault();
        }
    }
}

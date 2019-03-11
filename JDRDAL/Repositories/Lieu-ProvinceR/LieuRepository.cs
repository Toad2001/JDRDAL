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
    public class LieuRepository
    {
        public IEnumerable<Lieu> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Lieu");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Lieu());
        }

        public Lieu Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Lieu WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Lieu()).FirstOrDefault();
        }
    }
}

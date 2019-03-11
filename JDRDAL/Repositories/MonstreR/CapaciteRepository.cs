using JDRDAL.Mappers;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.MonstreR
{
    public class CapaciteRepository
    {
        public IEnumerable<Capacite> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Capacite");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Capacite());
        }

        public Capacite Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Capacite WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToCapacite()).FirstOrDefault();
        }
    }
}

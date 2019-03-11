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
    public class MonstreRepository
    {
        public IEnumerable<Monstre> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Monstre");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Monstre());
        }

        public Monstre Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Monstre WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToMonstre()).FirstOrDefault();
        }
    }
}

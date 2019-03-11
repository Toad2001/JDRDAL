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
    public class ArmureRepository
    {
        public IEnumerable<Armure> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Armure");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToArmure());
        }

        public Armure Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Armure WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToArmure()).FirstOrDefault();
        }
    }
}

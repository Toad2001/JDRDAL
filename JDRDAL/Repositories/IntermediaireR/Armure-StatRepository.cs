using JDRDAL.Models.Intermediaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.Objet.Intermediaire
{
    public class Armure_StatRepository
    {
        public IEnumerable<Armure_Stat> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Armure-Stat");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Armure_Stat());
        }

        public Armure_Stat Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Armure-Stat WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Armure_Stat()).FirstOrDefault();
        }
    }
}

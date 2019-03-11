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
    public class Arme_StatRepository
    {
        public IEnumerable<Arme_Stat> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Arme-Stat");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Arme_Stat());
        }

        public Arme_Stat Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Arme-Stat WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Arme_Stat()).FirstOrDefault();
        }
    }
}

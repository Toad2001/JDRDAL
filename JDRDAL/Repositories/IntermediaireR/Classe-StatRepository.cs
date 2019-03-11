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
    public class Classe_StatRepository
    {
        public IEnumerable<Classe_Stat> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Classe-Stat");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Classe_Stat());
        }

        public Classe_Stat Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Classe_Stat WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Classe_Stat()).FirstOrDefault();
        }
    }
}

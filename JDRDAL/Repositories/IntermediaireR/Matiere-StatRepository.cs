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
    public class Matiere_StatRepository
    {
        public IEnumerable<Matiere_Stat> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Matiere-Stat");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Matiere_Stat());
        }

        public Matiere_Stat Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Matiere-Stat WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Matiere_Stat()).FirstOrDefault();
        }
    }
}

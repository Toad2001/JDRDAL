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
    public class Monstre_StatRepository
    {
        public IEnumerable<Monstre_Stat> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Monstre-Stat");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Monstre_Stat());
        }

        public Monstre_Stat Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Monstre-Stat WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Monstre_Stat()).FirstOrDefault();
        }
    }
}

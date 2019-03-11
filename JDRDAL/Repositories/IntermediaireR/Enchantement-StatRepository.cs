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
    public class Enchantement_StatRepository
    {
        public IEnumerable<Enchantement_Stat> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Enchantement-Stat");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Enchantement_Stat());
        }

        public Enchantement_Stat Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Enchantement-Stat WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Enchantement_Stat()).FirstOrDefault();
        }
    }
}

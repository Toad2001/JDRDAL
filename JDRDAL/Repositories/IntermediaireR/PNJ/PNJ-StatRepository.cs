using JDRDAL.Models.Intermediaire.PNJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.Objet.Intermediaire.PNJ
{
    public class PNJ_StatRepository
    {
        public IEnumerable<PNJ_Stat> GetAll()
        {
            Command cmd = new Command("SELECT * FROM PJ-Stat");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new PNJ_Stat());
        }

        public PNJ_Stat Get(int id)
        {
            Command cmd = new Command("SELECT * FROM PJ-Stat WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new PNJ_Stat()).FirstOrDefault();
        }
    }
}

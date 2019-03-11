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
    public class PNJ_MagieRepository
    {
        public IEnumerable<PNJ_Magie> GetAll()
        {
            Command cmd = new Command("SELECT * FROM PJ-Magie");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new PNJ_Magie());
        }

        public PNJ_Magie Get(int id)
        {
            Command cmd = new Command("SELECT * FROM PJ-Magie WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new PNJ_Magie()).FirstOrDefault();
        }
    }
}

using JDRDAL.Models.Intermediaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.Objet.Intermediaire.PJ
{
    public class PJ_MagieRepository
    {
        public IEnumerable<PJ_Magie> GetAll()
        {
            Command cmd = new Command("SELECT * FROM PJ-Magie");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new PJ_Magie());
        }

        public PJ_Magie Get(int id)
        {
            Command cmd = new Command("SELECT * FROM PJ-Magie WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new PJ_Magie()).FirstOrDefault();
        }
    }
}

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
    public class PJ_ObjetRepository
    {
        public IEnumerable<PJ_Objet> GetAll()
        {
            Command cmd = new Command("SELECT * FROM PJ-Objet");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new PJ_Objet());
        }

        public PJ_Objet Get(int id)
        {
            Command cmd = new Command("SELECT * FROM PJ-Objet WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new PJ_Objet()).FirstOrDefault();
        }
    }
}

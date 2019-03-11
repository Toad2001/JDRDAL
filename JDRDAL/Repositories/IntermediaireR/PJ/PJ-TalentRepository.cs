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
    public class PJ_TalentRepository
    {
        public IEnumerable<PJ_Talent> GetAll()
        {
            Command cmd = new Command("SELECT * FROM PJ-Talent");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new PJ_Talent());
        }

        public PJ_Talent Get(int id)
        {
            Command cmd = new Command("SELECT * FROM PJ-Talent WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new PJ_Talent()).FirstOrDefault();
        }
    }
}

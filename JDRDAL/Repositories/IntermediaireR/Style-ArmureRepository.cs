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
    public class Style_ArmureRepository
    {
        public IEnumerable<Style_Armure> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Style-Armure");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Style_Armure());
        }

        public Style_Armure Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Style-Armure WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Style_Armure()).FirstOrDefault();
        }
    }
}

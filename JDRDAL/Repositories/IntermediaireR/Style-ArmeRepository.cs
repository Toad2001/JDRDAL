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
    public class Style_ArmeRepository
    {
        public IEnumerable<Style_Arme> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Style-Arme");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Style_Arme());
        }

        public Style_Arme Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Style-Arme WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Style_Arme()).FirstOrDefault();
        }
    }
}

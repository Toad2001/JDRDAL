using JDRDAL.Mappers;
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
    public class PJ_EquipementRepository
    {
        public IEnumerable<PJ_Equipement> GetAll()
        {
            Command cmd = new Command("SELECT * FROM [PJ-Equipement]");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new PJ_Equipement());
        }

        public IEnumerable< PJ_Equipement> Get(int id)
        {
            Command cmd = new Command("SELECT * FROM [PJ-Equipement] WHERE Id_PJ =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, bp => bp.ToPJ_Equipement());
        }
    }
}

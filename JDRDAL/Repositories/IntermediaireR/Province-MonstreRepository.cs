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
    public class Province_MonstreRepository
    {
        public IEnumerable<Province_Monstre> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Province-Monstre");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Province_Monstre());
        }

        public Province_Monstre Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Province-Monstre WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Province_Monstre()).FirstOrDefault();
        }
    }
}

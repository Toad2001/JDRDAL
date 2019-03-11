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
    public class Lieu_MonstreRepository
    {
        public IEnumerable<Lieu_Monstre> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Lieu-Monstre");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Lieu_Monstre());
        }

        public Lieu_Monstre Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Lieu-Monstre WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Lieu_Monstre()).FirstOrDefault();
        }
    }
}

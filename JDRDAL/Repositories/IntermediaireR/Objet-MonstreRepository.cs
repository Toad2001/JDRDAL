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
    public class Objet_MonstreRepository
    {
        public IEnumerable<Objet_Monstre> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Objet-Monstre");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Objet_Monstre());
        }

        public Objet_Monstre Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Objet-Monstre WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Objet_Monstre()).FirstOrDefault();
        }
    }
}

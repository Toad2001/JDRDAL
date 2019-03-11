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
    public class Race_StatRepository
    {
        public IEnumerable<Race_Stat> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Race-Stat");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Race_Stat());
        }

        public Race_Stat Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Race-Stat WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Race_Stat()).FirstOrDefault();
        }
    }
}

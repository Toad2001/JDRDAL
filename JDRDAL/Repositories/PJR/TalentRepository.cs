using JDRDAL.Mappers;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.PJR
{
    public class TalentRepository
    {
        public IEnumerable<Talent> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Talent");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToTalent());
        }

        public Talent Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Talent WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToTalent()).FirstOrDefault();
        }
    }
}

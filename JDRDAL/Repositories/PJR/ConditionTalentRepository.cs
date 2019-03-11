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
    public class ConditionTalentRepository
    {
        public IEnumerable<ConditionTalent> GetAll()
        {
            Command cmd = new Command("SELECT * FROM ConditionTalent");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToConditionTalent());
        }

        public ConditionTalent Get(int id)
        {
            Command cmd = new Command("SELECT * FROM ConditionTalent WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToConditionTalent()).FirstOrDefault();
        }
    }
}

using JDRDAL.Mappers;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.Stat
{
    public class CLasseStatRepository
    {
        public IEnumerable<ClasseStat> GetAll()
        {
            Command cmd = new Command("SELECT * FROM ClasseStat");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToClasseStat());
        }

        public ClasseStat Get(int id)
        {
            Command cmd = new Command("SELECT * FROM ClasseStat WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToClasseStat()).FirstOrDefault();
        }
    }
}

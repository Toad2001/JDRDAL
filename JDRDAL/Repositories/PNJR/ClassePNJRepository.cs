using JDRDAL.Mappers;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.PNJR
{
    public class ClassePNJRepository
    {
        public IEnumerable<ClassePNJ> GetAll()
        {
            Command cmd = new Command("SELECT * FROM ClassePNJ");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToClassePNJ());
        }

        public ClassePNJ Get(int id)
        {
            Command cmd = new Command("SELECT * FROM ClassePNJ WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToClassePNJ()).FirstOrDefault();
        }
    }
}

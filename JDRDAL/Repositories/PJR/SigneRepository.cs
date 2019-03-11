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
    public class SigneRepository
    {
        public IEnumerable<Signe> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Signe");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToSigne());
        }

        public Signe Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Signe WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToSigne()).FirstOrDefault();
        }
    }
}

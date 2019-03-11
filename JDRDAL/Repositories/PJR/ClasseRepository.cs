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
    public class ClasseRepository
    {
        public IEnumerable<Classe> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Classe");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToClasse());
        }

        public Classe Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Classe WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToClasse()).FirstOrDefault();
        }
    }
}

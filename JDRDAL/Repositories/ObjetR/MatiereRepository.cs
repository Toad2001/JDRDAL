using JDRDAL.Mappers;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;
using ToolBox.Pattern.Repository;

namespace JDRDAL.Repositories
{
    public class MatiereRepository : IRepository<int, Matiere>
    {
        public IEnumerable<Matiere> Get()
        {
            Command cmd = new Command("SELECT * FROM Matiere");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Matiere());
        }

        public Matiere Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Matiere WHERE Id =" + id);

            Matiere m = ServiceLocator.Instance.Connection.ExecuteReader(cmd, ma => ma.ToMatiere()).FirstOrDefault();
            return m; 
        }

        public Matiere Insert(Matiere entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Matiere entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using JDRDAL.Mappers;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories
{
    public class TypeArmeRepository
    {
        public IEnumerable<TypeArme> GetAll()
        {
            Command cmd = new Command("SELECT * FROM TypeArme");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToTypeArme());
        }

        public TypeArme Get(int id)
        {
            Command cmd = new Command("SELECT * FROM TypeArme WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToTypeArme()).FirstOrDefault();
        }
    }
}

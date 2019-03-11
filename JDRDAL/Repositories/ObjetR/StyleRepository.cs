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
    public class StyleRepository
    {
        public IEnumerable<Style> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Style");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToStyle());
        }

        public Style Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Style WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToStyle()).FirstOrDefault();
        }
    }
}

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
    public class ArmeRepository
    {
        public IEnumerable<Arme> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Arme");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToArme());
        }

        public Arme Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Arme WHERE Id ="+id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToArme()).FirstOrDefault();
        }        
    }
}

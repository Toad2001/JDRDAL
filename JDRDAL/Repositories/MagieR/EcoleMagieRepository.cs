using JDRDAL.Mappers;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.Magie
{
    public class EcoleMagieRepository
    {
        public IEnumerable<EcoleMagie> GetAll()
        {
            Command cmd = new Command("SELECT * FROM EcoleMagie");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new EcoleMagie());
        }

        public EcoleMagie Get(int id)
        {
            Command cmd = new Command("SELECT * FROM EcoleMagie WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToEcoleMagie()).FirstOrDefault();
        }
    }
}

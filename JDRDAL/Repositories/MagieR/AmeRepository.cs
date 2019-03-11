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
    public class AmeRepository
    {
        public IEnumerable<Ame> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Ame");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => new Ame());
        }

        public Ame Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Ame WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a =>  a.ToAme()).FirstOrDefault();
        }
    }
}

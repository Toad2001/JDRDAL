using JDRDAL.Mappers;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.MonstreR
{
    public class ResistenceRepository
    {
        public IEnumerable<Resistence> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Resistence");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToResistence());
        }

        public Resistence Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Resistence WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a =>  a.ToResistence()).FirstOrDefault();
        }
    }
}

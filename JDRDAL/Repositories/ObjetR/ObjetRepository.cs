using M = JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;
using JDRDAL.Mappers;

namespace JDRDAL.Repositories
{
    public class ObjetRepository
    {
        public IEnumerable<M.Objet> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Objet");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToObjet());
        }

        public M.Objet Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Objet WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a =>  a.ToObjet()).FirstOrDefault();
        }
    }
}

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
    public class EnchantementRepository
    {
        public IEnumerable<Enchantement> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Enchantement");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToEnchantement());
        }
        public Enchantement Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Enchantement WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToEnchantement()).FirstOrDefault();
        }
    }
}

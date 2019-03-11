using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.MappeurGeneric;
using ToolBox.Pattern.Locator;

namespace JDRBusiness.Services.ObjetS
{
    public class B_EnchantementService
    {
        private EnchantementRepository repo = new EnchantementRepository();

        public IEnumerable<B_Details> GetAll(int id)
        {
            Command cmd = new Command("SELECT S.Nom , PS.Valeur FROM [Enchantement-Stat] PS JOIN Stat S ON PS.Id_Stat = S.Id WHERE PS.Id_Enchantement = @Id");

            cmd.AddParameter("Id", id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, m => new B_Details() { NomStat = (string)m["Nom"], ValeurStat = (int)m["Valeur"] });
        }

        public B_Enchantement Get(int id)
        {
            return Mapper<Enchantement, B_Enchantement>.Map(repo.Get(id));
        }
    }
}

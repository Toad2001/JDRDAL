using JDRDAL.Mappers;
using JDRDAL.Models;
using JDRDAL.Models.Intermediaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;

namespace JDRDAL.Repositories.Objet.Intermediaire.PJ
{
    public class PJ_StatRepository
    {
        public IEnumerable<PJ_Stat> Get()
        {
            Command cmd = new Command("SELECT * FROM [PJ-Stat]");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToPJ_Stat());
        }

        public PJ_Stat Get(int id)
        {
            Command cmd = new Command("SELECT * FROM [PJ-Stat] WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, a => a.ToPJ_Stat()).FirstOrDefault();
        }

        public Models.PJ GetPJbyStat(int id)
        {
            Command cmd = new Command("SELECT Id_PJ FROM [PJ-Stat] WHERE Id =" + id);
            int temp = (int)ServiceLocator.Instance.Connection.ExecuteScalar(cmd);
            Command cmd2 = new Command("SELECT * FROM PJ WHERE Id =" + temp);
            return ServiceLocator.Instance.Connection.ExecuteReader(cmd2, pj => pj.ToPJ()).FirstOrDefault();
        }

        public bool Update(int id, PJ_Stat entity)
        {
            Command cmd = new Command("update [PJ-Stat] set Valeur = @Valeur where id =" + id);
            cmd.AddParameter("Valeur", entity.Valeur);
            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd) == 1;
        }

        public IEnumerable<PJDetails> GetAll(int id)
        {
            Command cmd = new Command("SelectStat", true);

            cmd.AddParameter("IdPJ", id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, bp => bp.ToPjDetails());
        }

        public PJDetails GetDetail(int id)
        {
            Command cmd = new Command("SelectStatDetail", true);

            cmd.AddParameter("Id", id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, bp => bp.ToPjDetails()).FirstOrDefault();
        }
    }
}

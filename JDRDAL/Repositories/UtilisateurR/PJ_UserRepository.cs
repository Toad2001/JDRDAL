using JDRDAL.Mappers;
using JDRDAL.Models.UtilisateurM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;
using ToolBox.Pattern.Repository;

namespace JDRDAL.Repositories.UtilisateurR
{
    public class PJ_UserRepository : IRepository<int, PJ_User>
    {
        public IEnumerable<PJ_User> Get()
        {
            Command cmd = new Command("Select * From PJ_User");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, r => r.ToPJ_User());
        }

        public PJ_User Get(int id)
        {
            Command cmd = new Command("Select * From PJ_User WHERE Id=" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, r => r.ToPJ_User()).FirstOrDefault();

        }

        public PJ_User Insert(PJ_User entity)
        {
            Command cmd = new Command("Insert into PJ_User (Id_User, Id_PJ) values (@Id_User,@Id_PJ)");

            cmd.AddParameter("Id_User", entity.Id_User);
            cmd.AddParameter("Id_PJ", entity.Id_PJ);

            entity.Id = ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd);

            return entity;
        }

        public bool Update(int id, PJ_User entity)
        {
            Command cmd = new Command("Update PJ_User Set Id_User = @Id_User, Id_PJ= @Id_PJ WHERE Id =" + id);

            cmd.AddParameter("Id_User", entity.Id_User);
            cmd.AddParameter("Id_PJ", entity.Id_PJ);

            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd) == 1;
        }

        public bool Delete(int id)
        {
            Command cmd = new Command("Delete PJ_User Where Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd) == 1;
        }
    }
}

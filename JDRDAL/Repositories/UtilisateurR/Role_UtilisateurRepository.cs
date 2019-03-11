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
    public class Role_UtilisateurRepository : IRepository<int, Role_Utilisateur>
    {
        public IEnumerable<Role_Utilisateur> Get()
        {
            Command cmd = new Command("Select * From Role_Utilisateur");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, r => r.ToRole_Utilisateur());
        }

        public Role_Utilisateur Get(int id)
        {
            Command cmd = new Command("Select * From Role_Utilisateur WHERE Id=" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, r => r.ToRole_Utilisateur()).FirstOrDefault();
        }

        public Role_Utilisateur Insert(Role_Utilisateur entity)
        {
            Command cmd = new Command("Insert into Role_Utilisateur (Id_Utilisateur, Id_Role) values (@Id_Utilisateur,@Id_Role)");

            cmd.AddParameter("Id_Utilisateur", entity.Id_Utilisateur);
            cmd.AddParameter("Id_Role", entity.Id_Role);

            entity.Id = ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd);

            return entity;
        }

        public bool Update(int id, Role_Utilisateur entity)
        {
            Command cmd = new Command("Update Role_Utilisateur Set Id_Utilisateur = @Id_Utilisateur, Id_Role= @Id_Role WHERE Id =" + id);

            cmd.AddParameter("Id_Utilisateur", entity.Id_Utilisateur);
            cmd.AddParameter("Id_Role", entity.Id_Role);

            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd) == 1;
        }

        public bool Delete(int id)
        {
            Command cmd = new Command("Delete Role_Utilisateur Where Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd) == 1;
        }
    }
}

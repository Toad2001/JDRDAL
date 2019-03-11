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
    public class RolesRepository : IRepository<int, Roles>
    {
        public IEnumerable<Roles> Get()
        {
            Command cmd = new Command("Select * From Roles");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, r => r.ToRoles());
        }

        public Roles Get(int id)
        {
            Command cmd = new Command("Select * From Roles WHERE Id=" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, r => r.ToRoles()).FirstOrDefault();
        }

        public Roles Insert(Roles entity)
        {
            Command cmd = new Command("Insert into Roles (Nom) values (@Nom)");

            cmd.AddParameter("Nom", entity.Nom);

            entity.Id = ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd);

            return entity;
        }

        public bool Update(int id, Roles entity)
        {
            Command cmd = new Command("Update Roles Set Nom = @Nom WHERE Id =" + id);

            cmd.AddParameter("Nom", entity.Nom);

            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd) == 1;
        }

        public bool Delete(int id)
        {
            Command cmd = new Command("Delete Roles Where Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd) == 1;
        }
    }
}

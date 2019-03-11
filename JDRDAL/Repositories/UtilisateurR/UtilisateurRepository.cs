using JDRDAL.Mappers;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;
using ToolBox.Pattern.Repository;

namespace JDRDAL.Repositories
{
    public class UtilisateurRepository : IRepository<int, Utilisateur>
    {
        public IEnumerable<Utilisateur> Get()
        {
            Command cmd = new Command("SELECT * FROM Utilisateur");

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, u => u.ToUser());
        }

        public Utilisateur Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Utilisateur WHERE Id =" + id);

            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, u => u.ToUser()).FirstOrDefault();
        }

        public Utilisateur Insert(Utilisateur entity)
        {
            Command cmd = new Command("AjouterUtilisateur", true);

            cmd.AddParameter("Nom", entity.Nom);
            cmd.AddParameter("Prenom", entity.Prenom);
            cmd.AddParameter("Login", entity.Login);
            cmd.AddParameter("Password", entity.Password);
            cmd.AddParameter("Email", entity.Email);

            entity.Id = (int)ServiceLocator.Instance.Connection.ExecuteScalar(cmd);

            return entity;

        }

        public bool Update(int id, Utilisateur entity)
        {
            Command cmd = new Command("ModifierUtilisateur", true);

            cmd.AddParameter("Nom", entity.Nom);
            cmd.AddParameter("Prenom", entity.Prenom);
            cmd.AddParameter("Login", entity.Login);
            cmd.AddParameter("Password", entity.Password);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("Id", id);

            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd) == 1;
        }

        public bool Delete(int id)
        {
            Command cmd = new Command("SupprimerUtilisateur", true);

            cmd.AddParameter("Id", id);

            return ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd) == 1;
        }
    }
}

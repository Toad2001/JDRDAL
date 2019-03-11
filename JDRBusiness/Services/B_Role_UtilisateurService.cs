using JDRBusiness.Mappers;
using JDRBusiness.Models;
using JDRDAL.Repositories.UtilisateurR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Pattern.Repository;

namespace JDRBusiness.Services
{
    public class B_Role_UtilisateurService : IRepository<int, B_Role_Utilisateur>
    {
        Role_UtilisateurRepository ru = new Role_UtilisateurRepository();

        public IEnumerable<B_Role_Utilisateur> Get()
        {
            return ru.Get().Select(ro => ro.ToBuisnessRoleUtilisateur());
        }

        public B_Role_Utilisateur Get(int id)
        {
            return ru.Get(id).ToBuisnessRoleUtilisateur();
        }

        public B_Role_Utilisateur Insert(B_Role_Utilisateur entity)
        {
            return ru.Insert(entity.ToGlobalRoleUtilisateur()).ToBuisnessRoleUtilisateur();
        }

        public bool Update(int id, B_Role_Utilisateur entity)
        {
            return ru.Update(id,entity.ToGlobalRoleUtilisateur());
        }

        public bool Delete(int id)
        {
            return ru.Delete(id);
        }
    }
}

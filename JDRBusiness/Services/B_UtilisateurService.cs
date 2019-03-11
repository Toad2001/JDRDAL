using JDRBusiness.Mappers;
using JDRBusiness.Models;
using JDRDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Pattern.Repository;

namespace JDRBusiness.Services
{
    public class B_UtilisateurService : IRepository<int, B_Utilisateur>
    {
        UtilisateurRepository ur = new UtilisateurRepository();

        public IEnumerable<B_Utilisateur> Get()
        {
            return ur.Get().Select(u => u.ToBuisnessUtilisateur());
        }

        public B_Utilisateur Get(int id)
        {
            return ur.Get(id).ToBuisnessUtilisateur();
        }

        public B_Utilisateur Insert(B_Utilisateur entity)
        {
            return ur.Insert(entity.ToGlobalUtilisateur()).ToBuisnessUtilisateur();
        }

        public bool Update(int id, B_Utilisateur entity)
        {
            return ur.Update(id,entity.ToGlobalUtilisateur());
        }

        public bool Delete(int id)
        {
            return ur.Delete(id);
        }
    }
}

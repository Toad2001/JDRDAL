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
    public class B_RolesService : IRepository<int, B_Roles>
    {
        RolesRepository rr = new RolesRepository();

        public IEnumerable<B_Roles> Get()
        {
            return rr.Get().Select(r => r.ToBuisnessRoles());
        }

        public B_Roles Get(int id)
        {
            return rr.Get(id).ToBuisnessRoles();
        }

        public B_Roles Insert(B_Roles entity)
        {
            return rr.Insert(entity.ToGlobalRoles()).ToBuisnessRoles();
        }

        public bool Update(int id, B_Roles entity)
        {
            return rr.Update(id,entity.ToGlobalRoles());
        }

        public bool Delete(int id)
        {
            return rr.Delete(id);
        }
    }
}

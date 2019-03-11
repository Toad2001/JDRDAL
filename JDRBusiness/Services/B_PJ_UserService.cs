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
    public class B_PJ_UserService : IRepository<int, B_PJ_User>
    {
        PJ_UserRepository pr = new PJ_UserRepository();

        public IEnumerable<B_PJ_User> Get()
        {
            return pr.Get().Select(pj => pj.ToBuisnessPJ_User());
        }

        public B_PJ_User Get(int id)
        {
            return pr.Get(id).ToBuisnessPJ_User();
        }

        public B_PJ_User Insert(B_PJ_User entity)
        {
            return pr.Insert(entity.ToGlobalPJ_User()).ToBuisnessPJ_User();
        }

        public bool Update(int id, B_PJ_User entity)
        {
            return pr.Update(id,entity.ToGlobalPJ_User());
        }

        public bool Delete(int id)
        {
            return pr.Delete(id);
        }
    }
}

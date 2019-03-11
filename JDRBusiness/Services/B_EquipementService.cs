using JDRBusiness.Mappers;
using JDRBusiness.Models;
using JDRDAL.Repositories.ObjetR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.Pattern.Locator;
using ToolBox.Pattern.Repository;

namespace JDRBusiness.Services
{
    public class B_EquipementService : IRepository<int, B_Equipement>
    {
        private EquipementRepository equipementR = new EquipementRepository();

        public IEnumerable<B_Equipement> Get()
        {
            return equipementR.Get().Select(e => e.ToBusiness()) ;
        }

        public B_Equipement Get(int id)
        {
            return equipementR.Get(id).ToBusiness();
        }

        public B_Equipement Insert(B_Equipement entity)
        {
            return equipementR.Insert(entity.ToDAL()).ToBusiness();
        }

        public bool Update(int id, B_Equipement entity)
        {
            return equipementR.Update(id, entity.ToDAL());
        }

        public bool Delete(int id)
        {
            return equipementR.Delete(id);
        }
    }
}

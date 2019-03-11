using JDRBusiness.Models;
using JDRDAL.Models.ObjetM;
using JDRDAL.Repositories.ObjetR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.MappeurGeneric;
using ToolBox.Pattern.Locator;
using ToolBox.Pattern.Repository;

namespace JDRBusiness.Services
{
    public class B_EquipementService : IRepository<int, B_Equipement>
    {
        private EquipementRepository equipementR = new EquipementRepository();

        public IEnumerable<B_Equipement> Get()
        {
            return equipementR.Get().Select(e => Mapper<Equipement, B_Equipement>.Map(e)) ;
        }

        public B_Equipement Get(int id)
        {
            return Mapper<Equipement,B_Equipement >.Map( equipementR.Get(id));
        }

        public B_Equipement Insert(B_Equipement entity)
        {
            return Mapper<Equipement, B_Equipement>.Map(equipementR.Insert(Mapper<B_Equipement, Equipement>.Map(entity)));
        }

        public bool Update(int id, B_Equipement entity)
        {
            return equipementR.Update(id, Mapper < B_Equipement, Equipement >.Map(entity));
        }

        public bool Delete(int id)
        {
            return equipementR.Delete(id);
        }
    }
}

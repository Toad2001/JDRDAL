using JDRBusiness.Services;
using JDRHelper.Mappers;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToolBox.Pattern.Repository;

namespace JDRHelper.Services
{
    internal class H_EquipementService : IRepository<int, H_Equipement>
    {
        B_EquipementService equipementService = new B_EquipementService();

        public IEnumerable<H_Equipement> Get()
        {
            return equipementService.Get().Select(e => e.ToHelper());
        }

        public H_Equipement Get(int id)
        {
            return equipementService.Get(id).ToHelper();
        }

        public H_Equipement Insert(H_Equipement entity)
        {
            return equipementService.Insert(entity.ToBusiness()).ToHelper();
        }

        public bool Update(int id, H_Equipement entity)
        {
            return equipementService.Update(id, entity.ToBusiness());
        }

        public bool Delete(int id)
        {
            return equipementService.Delete(id);
        }
    }
}
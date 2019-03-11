using JDRBusiness.Models;
using JDRBusiness.Services;
using JDRBusiness.Services.IntermediaireS;
using JDRHelper.Mappers;
using JDRHelper.Models;
using JDRHelper.Models.Intermediaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToolBox.MappeurGeneric;
using ToolBox.Pattern.Repository;

namespace JDRHelper.Services
{
    internal class H_EquipementService : IRepository<int, H_Equipement>
    {
        private B_EquipementService equipementService = new B_EquipementService();
        private B_PJ_EquipementService pjequipementService = new B_PJ_EquipementService();

        public IEnumerable<H_Equipement> Get()
        {
            return equipementService.Get().Select(e => Mapper<B_Equipement, H_Equipement>.Map(e));
        }

        public H_Equipement Get(int id)
        {
            return Mapper<B_Equipement, H_Equipement>.Map(equipementService.Get(id));
        }

        public H_Equipement Insert(H_Equipement entity)
        {
            return Mapper<B_Equipement, H_Equipement>.Map(equipementService.Insert(Mapper<H_Equipement, B_Equipement>.Map(entity)));
        }

        public bool Update(int id, H_Equipement entity)
        {
            return equipementService.Update(id, Mapper<H_Equipement, B_Equipement>.Map(entity));
        }

        public bool Delete(int id)
        {
            return equipementService.Delete(id);
        }

        public IEnumerable<H_Equipement> GetForPJ(int id) // Faire le ToHelper, puis ajouter aux contrôler pour pouvoir obtenir la liste des equipements du PJ
        {
            List<H_Equipement> equipements = new List<H_Equipement>();

            IEnumerable<H_PJ_Equipement> list = (pjequipementService.Get(id).ToList()).ToHelper();

            foreach (var item in list)
            {
                equipements.Add(Mapper<B_Equipement, H_Equipement>.Map(equipementService.Get(item.Id_Equipement)));
            }
            return equipements;
        }

    }
}
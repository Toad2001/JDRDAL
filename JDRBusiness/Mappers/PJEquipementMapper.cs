using JDRBusiness.Models.Intermediaire;
using JDRDAL.Models.Intermediaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Mappers
{
    internal static class PJEquipementMapper
    {
        internal static List<B_PJ_Equipement> ToBusiness(this List<PJ_Equipement> entity)
        {
            List<B_PJ_Equipement> list = new List<B_PJ_Equipement>();

            foreach (PJ_Equipement item in entity)
            {
                list.Add(item.ToBEquipement());
            }
            return list;
        }

        internal static B_PJ_Equipement ToBEquipement(this PJ_Equipement entity)
        {
            return new B_PJ_Equipement() { Id_Equipement = entity.Id_Equipement, Id_PJ = entity.Id_PJ};
        }
    }
}

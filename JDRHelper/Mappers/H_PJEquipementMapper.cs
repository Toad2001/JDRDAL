using JDRBusiness.Models.Intermediaire;
using JDRHelper.Models.Intermediaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDRHelper.Mappers
{
    internal static class H_PJEquipementMapper
    {
        internal static List<H_PJ_Equipement> ToHelper(this List<B_PJ_Equipement> entity)
        {
            List<H_PJ_Equipement> list = new List<H_PJ_Equipement>();

            foreach (B_PJ_Equipement item in entity)
            {
                list.Add(item.ToH());
            }
            return list;
        }

        internal static H_PJ_Equipement ToH(this B_PJ_Equipement entity)
        {
            return new H_PJ_Equipement() { Id_Equipement = entity.Id_Equipement, Id_PJ = entity.Id_PJ };
        }
    }


}
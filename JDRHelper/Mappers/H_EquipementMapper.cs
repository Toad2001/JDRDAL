using JDRBusiness.Models;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDRHelper.Mappers
{
    internal static class H_EquipementMapper
    {
        internal static B_Equipement ToBusiness (this H_Equipement entity)
        {
            return new B_Equipement()
            {
                Id = entity.Id,
                Id_Arme = entity.Id_Arme,
                Id_Armure = entity.Id_Armure,
                Id_Matiere = entity.Id_Matiere,
                Id_Style = entity.Id_Style,
                Id_Enchantement = entity.Id_Enchantement
            };
        }

        internal static H_Equipement ToHelper (this B_Equipement entity)
        {
            return new H_Equipement()
            {
                Id = entity.Id,
                Id_Arme = entity.Id_Arme,
                Id_Armure = entity.Id_Armure,
                Id_Matiere = entity.Id_Matiere,
                Id_Style = entity.Id_Style,
                Id_Enchantement = entity.Id_Enchantement
            };
        }

    }
}
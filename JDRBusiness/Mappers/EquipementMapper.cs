using JDRBusiness.Models;
using JDRDAL.Models.Intermediaire;
using JDRDAL.Models.ObjetM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Mappers
{
    internal static class EquipementMapper
    {
        internal static B_Equipement ToBusiness(this Equipement entity)
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

        internal static Equipement ToDAL(this B_Equipement entity)
        {
            return new Equipement()
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

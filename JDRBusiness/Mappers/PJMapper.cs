using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Models.Intermediaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Mappers
{
    internal static class PJMapper
    {
        internal static B_PJ ToBusiness(this PJ entity)
        {
            return new B_PJ() { Id= entity.Id, Nom = entity.Nom, Sexe = entity.Sexe , Blesse = entity.Blesse, Esquive = entity.Esquive , CoupPuissant = entity.CoupPuissant, Id_Race = entity.Id_Race, Id_Classe = entity.Id_Classe, Id_Signe = entity.Id_Signe, ValeurD4 = entity.ValeurD4 };
        }

        internal static PJ ToDAL(this B_PJ entity)
        {
            return new PJ() { Id = entity.Id, Nom = entity.Nom, Sexe = entity.Sexe, Blesse = entity.Blesse, Esquive = entity.Esquive, CoupPuissant = entity.CoupPuissant, Id_Race = entity.Id_Race, Id_Classe = entity.Id_Classe, Id_Signe = entity.Id_Signe, ValeurD4 = entity.ValeurD4 };
        }

        internal static B_PJ_Stat ToBusiness(this PJ_Stat entity)
        {
            return new B_PJ_Stat() { Id = entity.Id, Id_PJ= entity.Id_PJ, Id_Stat = entity.Id_Stat, Valeur=entity.Valeur };
        }

        internal static PJ_Stat ToDAL(this B_PJ_Stat entity)
        {
            return new PJ_Stat() { Id = entity.Id, Id_PJ = entity.Id_PJ, Id_Stat = entity.Id_Stat, Valeur = entity.Valeur };
        }

        internal static B_PJDetails ToPJDetails(this B_Stat entity, B_PJ_Stat entityStat)
        {
            return new B_PJDetails() { Nom = entity.Nom , Valeur = entityStat.Valeur};
        }
    }
}

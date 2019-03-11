using JDRBusiness.Models;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDRHelper.Mappers
{
    internal static class H_MatiereMapper
    {
        internal static B_Matiere ToBusiness(this H_Matiere entity)
        {
            return new B_Matiere() { Id = entity.Id, Nom = entity.Nom};
        }

        internal static H_Matiere ToHelper(this B_Matiere entity)
        {
            return new H_Matiere() { Id = entity.Id, Nom = entity.Nom };
        }

        internal static B_Matiere_Stat ToBusiness(this H_Matiere_Stat entity)
        {
            return new B_Matiere_Stat() { Id = entity.Id, Id_Matiere = entity.Id_Matiere, Id_Stat = entity.Id_Stat, Valeur = entity.Valeur };
        }

        internal static H_Matiere_Stat ToHepler(this B_Matiere_Stat entity)
        {
            return new H_Matiere_Stat() { Id = entity.Id, Id_Matiere = entity.Id_Matiere, Id_Stat = entity.Id_Stat, Valeur = entity.Valeur };
        }

        internal static H_Details ToMatiereDetails(this H_Stat entity, H_Matiere_Stat entityStat)
        {
            return new H_Details() { NomStat = entity.Nom, ValeurStat = entityStat.Valeur };
        }

        
    }

}
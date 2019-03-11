using JDRBusiness.Models;
using JDRDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDRBusiness.Mappers
{
    internal static class DetailsMapper
    {
        //internal static B_PJ ToBusiness(this H_PJ entity)
        //{
        //    return new B_PJ() { Id = entity.Id, Nom = entity.Nom, Sexe = entity.Sexe, Blesse = entity.Blesse, Esquive = entity.Esquive, CoupPuissant = entity.CoupPuissant, Id_Race = entity.Id_Race, Id_Classe = entity.Id_Classe, Id_Signe = entity.Id_Signe, ValeurD4 = entity.ValeurD4 };
        //}

        //internal static H_PJ ToHelper (this B_PJ entity)
        //{
        //    return new H_PJ() { Id = entity.Id, Nom = entity.Nom, Sexe = entity.Sexe, Blesse = entity.Blesse, Esquive = entity.Esquive, CoupPuissant = entity.CoupPuissant, Id_Race = entity.Id_Race, Id_Classe = entity.Id_Classe, Id_Signe = entity.Id_Signe, ValeurD4 = entity.ValeurD4 };
        //}

        //internal static B_PJ_Stat ToBusiness(this H_PJ_Stat entity)
        //{
        //    return new B_PJ_Stat() { Id = entity.Id, Id_PJ = entity.Id_PJ, Id_Stat = entity.Id_Stat, Valeur = entity.Valeur };
        //}

        //internal static H_PJ_Stat ToHepler(this B_PJ_Stat entity)
        //{
        //    return new H_PJ_Stat() { Id = entity.Id, Id_PJ = entity.Id_PJ, Id_Stat = entity.Id_Stat, Valeur = entity.Valeur };
        //}

        //internal static H_PJDetails ToPJDetails(this H_Stat entity, H_PJ_Stat entityStat)
        //{
        //    return new H_PJDetails() { NomStat = entity.Nom, ValeurStat = entityStat.Valeur };
        //}

        internal static PJDetails ToDalDetail(this B_PJDetails entity)
        {
            return new PJDetails() { Id = entity.Id, Nom = entity.Nom, Valeur = entity.Valeur };
        }

        internal static B_PJDetails ToBDetail(this PJDetails entity)
        {
            return new B_PJDetails() { Id = entity.Id, Nom = entity.Nom, Valeur = entity.Valeur };
        }

        internal static List<PJDetails> ToDal(this List<B_PJDetails> entity)
        {
            List<PJDetails> list = new List<PJDetails>();

            foreach (B_PJDetails item in entity)
            {
                list.Add(item.ToDalDetail());
            }
            return list;
        }

        internal static List<B_PJDetails> ToBusiness(this List<PJDetails> entity)
        {
            List<B_PJDetails> list = new List<B_PJDetails>();

            foreach (PJDetails item in entity)
            {
                list.Add(item.ToBDetail());
            }
            return list;
        }
    }
}

using JDRBusiness.Models;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDRHelper.Mappers
{
    internal static class H_PJMapper
    {
        internal static B_PJ ToBusiness(this H_PJ entity)
        {
            return new B_PJ() { Id = entity.Id, Nom = entity.Nom, Sexe = entity.Sexe, Blesse = entity.Blesse, Esquive = entity.Esquive, CoupPuissant = entity.CoupPuissant, Id_Race = entity.Id_Race, Id_Classe = entity.Id_Classe, Id_Signe = entity.Id_Signe, ValeurD4 = entity.ValeurD4 };
        }

        internal static H_PJ ToHelper (this B_PJ entity)
        {
            return new H_PJ() { Id = entity.Id, Nom = entity.Nom, Sexe = entity.Sexe, Blesse = entity.Blesse, Esquive = entity.Esquive, CoupPuissant = entity.CoupPuissant, Id_Race = entity.Id_Race, Id_Classe = entity.Id_Classe, Id_Signe = entity.Id_Signe, ValeurD4 = entity.ValeurD4 };
        }

        internal static B_PJ_Stat ToBusiness(this H_PJ_Stat entity)
        {
            return new B_PJ_Stat() { Id = entity.Id, Id_PJ = entity.Id_PJ, Id_Stat = entity.Id_Stat, Valeur = entity.Valeur };
        }

        internal static H_PJ_Stat ToHepler(this B_PJ_Stat entity)
        {
            return new H_PJ_Stat() { Id = entity.Id, Id_PJ = entity.Id_PJ, Id_Stat = entity.Id_Stat, Valeur = entity.Valeur };
        }

        internal static H_PJDetails ToPJDetails(this H_Stat entity, H_PJ_Stat entityStat)
        {
            return new H_PJDetails() { Nom = entity.Nom, Valeur = entityStat.Valeur };
        }

        internal static B_PJDetails ToBDetail(this H_PJDetails entity)
        {
            return new B_PJDetails() { Nom = entity.Nom, Valeur= entity.Valeur };
        }

        internal static H_PJDetails ToHDetail(this B_PJDetails entity)
        {
            return new H_PJDetails() { Id = entity.Id, Nom = entity.Nom, Valeur = entity.Valeur };
        }

        internal static List<B_PJDetails> ToHelper(this List<H_PJDetails> entity)
        {
            List<B_PJDetails> list = new List<B_PJDetails>();

            foreach (H_PJDetails item in entity)
            {
                list.Add(item.ToBDetail());
            }

            return list;
        }

        internal static List<H_PJDetails> ToHelper(this List<B_PJDetails> entity)
        {
            List<H_PJDetails> list = new List<H_PJDetails>();

            

            foreach (B_PJDetails item in entity)
            {
                list.Add(item.ToHDetail());
            }

            return list;
        }
    }
}
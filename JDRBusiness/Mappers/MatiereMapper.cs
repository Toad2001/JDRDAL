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
    internal static class MatiereMapper
    {
        internal static B_Matiere ToBusiness(this Matiere entity)
        {
            return new B_Matiere() { Id = entity.Id, Nom = entity.Nom, Arme = entity.Arme, ArmureLegere = entity.ArmureLegere, ArmureLourd = entity.ArmureLourd };
        }

        internal static Matiere ToDAL(this B_Matiere entity)
        {
            return new Matiere() { Id = entity.Id, Nom = entity.Nom, Arme = entity.Arme, ArmureLegere = entity.ArmureLegere, ArmureLourd = entity.ArmureLourd };
        }

        internal static B_Matiere_Stat ToBusiness(this Matiere_Stat entity)
        {
            return new B_Matiere_Stat() { Id = entity.Id, Id_Matiere = entity.Id_Matiere, Id_Stat = entity.Id_Stat, Valeur = entity.Valeur };
        }

        internal static Matiere_Stat ToDAL(this B_Matiere_Stat entity)
        {
            return new Matiere_Stat() { Id = entity.Id, Id_Matiere = entity.Id_Matiere, Id_Stat = entity.Id_Stat, Valeur = entity.Valeur };
        }

        internal static B_Details ToMatiereDetails(this B_Stat entity, B_Matiere_Stat entityStat)
        {
            return new B_Details() { NomStat = entity.Nom, ValeurStat = entityStat.Valeur };
        }

    }


}

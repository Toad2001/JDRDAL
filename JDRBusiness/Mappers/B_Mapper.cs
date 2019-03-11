using System;
using B = JDRBusiness.Models;
using G = JDRDAL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;
using JDRDAL.Models.UtilisateurM;
using JDRBusiness.Models;

namespace JDRBusiness.Mappers
{
    internal static class B_Mapper
    {
        internal static B.B_Utilisateur ToBuisnessUtilisateur(this G.Utilisateur entity)
        {
            return Mapper<G.Utilisateur, B.B_Utilisateur>.Map(entity);
        }

        internal static G.Utilisateur ToGlobalUtilisateur(this B.B_Utilisateur entity)
        {
            return Mapper<B.B_Utilisateur, G.Utilisateur>.Map(entity);
        }

        internal static Roles ToGlobalRoles(this B_Roles entity)
        {
            return Mapper<B_Roles, Roles>.Map(entity);
        }

        internal static B_Roles ToBuisnessRoles(this Roles entity)
        {
            return Mapper<Roles, B_Roles>.Map(entity);
        }

        internal static PJ_User ToGlobalPJ_User(this B_PJ_User entity)
        {
            return Mapper<B_PJ_User, PJ_User>.Map(entity);
        }

        internal static B_PJ_User ToBuisnessPJ_User(this PJ_User entity)
        {
            return Mapper<PJ_User, B_PJ_User>.Map(entity);
        }

        internal static Role_Utilisateur ToGlobalRoleUtilisateur(this B_Role_Utilisateur entity)
        {
            return Mapper<B_Role_Utilisateur, Role_Utilisateur>.Map(entity);
        }

        internal static B_Role_Utilisateur ToBuisnessRoleUtilisateur(this Role_Utilisateur entity)
        {
            return Mapper<Role_Utilisateur, B_Role_Utilisateur>.Map(entity);
        }

    }
}

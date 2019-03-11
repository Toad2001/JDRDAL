using JDRBusiness.Models;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Mappers
{
    internal static class H_Mapper
    {
        internal static H_Utilisateur ToASPUtilisateur(this B_Utilisateur entity)
        {
            return Mapper<B_Utilisateur, H_Utilisateur>.Map(entity);
        }

        internal static B_Utilisateur ToBuisnessUtilisateur(this H_Utilisateur entity)
        {
            return Mapper<H_Utilisateur, B_Utilisateur>.Map(entity);
        }
    }
}
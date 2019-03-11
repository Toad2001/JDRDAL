using JDRBusiness.Models;
using JDRBusiness.Models.Intermediaire;
using JDRBusiness.Services;
using JDRBusiness.Services.IntermediaireS;
using JDRHelper.Mappers;
using JDRHelper.Models;
using JDRHelper.Models.Intermediaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services.IntermediaireS
{
    public class H_PJ_EquipementService
    {
        private B_PJ_EquipementService repo = new B_PJ_EquipementService();
        private B_EquipementService equipementService = new B_EquipementService();
        private B_PJService pjrepo = new B_PJService();

        //public H_PJ_Equipement Get(int id)
        //{
        //    return Mapper<B_PJ_Equipement, H_PJ_Equipement>.Map(repo.Get(id));
        //}

    }
}
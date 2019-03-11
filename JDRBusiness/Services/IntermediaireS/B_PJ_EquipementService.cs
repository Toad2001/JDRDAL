using JDRBusiness.Mappers;
using JDRBusiness.Models;
using JDRBusiness.Models.Intermediaire;
using JDRDAL.Models;
using JDRDAL.Models.Intermediaire;
using JDRDAL.Models.ObjetM;
using JDRDAL.Repositories.Objet.Intermediaire.PJ;
using JDRDAL.Repositories.ObjetR;
using JDRDAL.Repositories.PJR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MappeurGeneric;

namespace JDRBusiness.Services.IntermediaireS
{
    public class B_PJ_EquipementService
    {
        private PJ_EquipementRepository repo = new PJ_EquipementRepository();
        private PJRepository pjrepo = new PJRepository();


        public IEnumerable<B_PJ_Equipement> Get(int id)
        {
            return repo.Get(id).ToList().ToBusiness();
        }

    }
}

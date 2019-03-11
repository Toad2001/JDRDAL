using JDRBusiness.Mappers;
using JDRBusiness;
using JDRDAL;
using JDRBusiness.Models;
using JDRDAL.Models;
using JDRDAL.Models.Intermediaire;
using JDRDAL.Repositories.Objet.Intermediaire.PJ;
using JDRDAL.Repositories.PJR;
using JDRDAL.Repositories.Stat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections.Database;
using ToolBox.MappeurGeneric;
using ToolBox.Pattern.Locator;

namespace JDRBusiness.Services
{
    public class B_PJDetailsService
    {
        private PJ_StatRepository repo = new PJ_StatRepository();
        private PJRepository pjrepo = new PJRepository();
        private StatRepository statrepo = new StatRepository();

        public IEnumerable<B_PJDetails> Get()
        {
            List<B_PJDetails> details = new List<B_PJDetails>();

            details = repo.Get().Select(u => Mapper<PJ_Stat, B_PJDetails>.Map(u)).ToList();

            foreach (B_PJDetails item in details)
            {
                item.Nom = statrepo.Get(item.Id).Nom;
            }          

            return details; 
        }

        public IEnumerable<B_PJDetails> GetAll(int id)
        {
            B_PJ PJ = Mapper<PJ, B_PJ>.Map(pjrepo.Get(id));

            return PJ.Details = (repo.GetAll(PJ.Id).ToList()).ToBusiness();
        }

        public B_PJDetails Get(int id)
        {
            return Mapper<PJDetails, B_PJDetails>.Map(repo.GetDetail(id));

        }

        public B_PJ GetPJbyStat(int id)
        {
            return Mapper<PJ, B_PJ>.Map(repo.GetPJbyStat(id));

        }

        public bool Update(int id, B_PJDetails entity)
        {
            return repo.Update(id, Mapper<B_PJDetails, PJ_Stat>.Map(entity));
        }
    }
}

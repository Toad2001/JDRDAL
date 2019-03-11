using JDRBusiness.Models;
using JDRBusiness.Services;
using JDRHelper.Mappers;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Services
{
    public class H_PJDetailsService
    {
        private B_PJDetailsService repo = new B_PJDetailsService();
        private B_PJService pjrepo = new B_PJService();

        public IEnumerable<H_PJDetails> Get()
        {
            return repo.Get().Select(u => Mapper<B_PJDetails, H_PJDetails>.Map(u));
        }

        public H_PJDetails Get(int id)
        {
            return Mapper<B_PJDetails, H_PJDetails>.Map(repo.Get(id));
        }

        public H_PJ GetPJbyStat(int id)
        {
            return Mapper<B_PJ, H_PJ>.Map(repo.GetPJbyStat(id));
        }

        public bool Update(int id, H_PJDetails entity)
        {
            return repo.Update(id, Mapper<H_PJDetails, B_PJDetails>.Map(entity));
        }

        public IEnumerable<H_PJDetails> GetAll(int id)
        {
            H_PJ h_PJ = Mapper<B_PJ, H_PJ>.Map(pjrepo.Get(id));

            return h_PJ.Details = (repo.GetAll(h_PJ.Id).ToList()).ToHelper();
        }

    }
}
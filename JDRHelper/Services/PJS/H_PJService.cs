using JDRBusiness.Models;
using JDRBusiness.Services;
using JDRHelper.Mappers;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToolBox.MappeurGeneric;
using ToolBox.Pattern.Repository;

namespace JDRHelper.Services
{
    public class H_PJService : IRepository<int, H_PJ>
    {
        B_PJService pJService = new B_PJService();

        public IEnumerable<H_PJDetails> GetAll(int id)
        {
            H_PJ h_PJ = Mapper<B_PJ, H_PJ>.Map(pJService.Get(id));
            
           return h_PJ.Details = (pJService.GetAll(h_PJ.Id).ToList()).ToHelper();
        }

        public IEnumerable<H_PJ> Get()
        {
            return pJService.Get().Select(pj => Mapper<B_PJ, H_PJ>.Map(pj));
        }

        public H_PJ Get(int id)
        {
            return Mapper<B_PJ, H_PJ>.Map(pJService.Get(id));
        }

        public H_PJ Insert(H_PJ entity)
        {
            return Mapper<B_PJ, H_PJ>.Map(pJService.Insert(Mapper<H_PJ, B_PJ>.Map( entity)));

        }

        public bool Update(int id, H_PJ entity)
        {
            return pJService.Update(id, (Mapper<H_PJ, B_PJ>.Map(entity)));
        }

        public bool Delete(int id)
        {
            return pJService.Delete(id);
        }
    }
}
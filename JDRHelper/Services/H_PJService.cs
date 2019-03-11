using JDRBusiness.Models;
using JDRBusiness.Services;
using JDRHelper.Mappers;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToolBox.Pattern.Repository;

namespace JDRHelper.Services
{
    public class H_PJService : IRepository<int, H_PJ>
    {
        B_PJService pJService = new B_PJService();

        public IEnumerable<H_PJDetails> GetAll(int id)
        {
            H_PJ h_PJ = pJService.Get(id).ToHelper();
            


           return h_PJ.Details = (pJService.GetAll(h_PJ.Id).ToList()).ToHelper();
        }

        public IEnumerable<H_PJ> Get()
        {
            return pJService.Get().Select(pj => pj.ToHelper());
        }

        public H_PJ Get(int id)
        {
            return pJService.Get(id).ToHelper();
        }

        public H_PJ Insert(H_PJ entity)
        {
            return pJService.Insert(entity.ToBusiness()).ToHelper();
        }

        public bool Update(int id, H_PJ entity)
        {
            return pJService.Update(id,entity.ToBusiness());
        }

        public bool Delete(int id)
        {
            return pJService.Delete(id);
        }
    }
}
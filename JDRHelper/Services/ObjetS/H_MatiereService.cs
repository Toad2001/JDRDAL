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
    public class H_MatiereService : IRepository<int, H_Matiere>
    {
        B_MatiereService matiereService = new B_MatiereService();

        public IEnumerable<H_Details> GetAll(int id)
        {
            H_Matiere h_Matiere = Mapper<B_Matiere, H_Matiere>.Map(matiereService.Get(id));
            return h_Matiere.Details = (matiereService.GetAll(h_Matiere.Id).ToList()).ToHelper();
        }

        public IEnumerable<H_Matiere> Get()
        {
            return matiereService.Get().Select(m => Mapper<B_Matiere, H_Matiere>.Map(m));
        }

        public H_Matiere Get(int id)
        {
            return Mapper<B_Matiere, H_Matiere>.Map(matiereService.Get(id));
        }

        public H_Matiere Insert(H_Matiere entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, H_Matiere entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
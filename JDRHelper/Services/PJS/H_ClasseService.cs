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
    public class H_ClasseService
    {
        B_ClasseService ClasseService = new B_ClasseService();

        public IEnumerable<H_Details> GetAll(int id)
        {
            H_Classe h_Classe = Mapper<B_Classe, H_Classe>.Map(ClasseService.Get(id));
            return h_Classe.Details = (ClasseService.GetAll(h_Classe.Id).ToList()).ToHelper();
        }

        public IEnumerable<H_Classe> Get()
        {
            return ClasseService.Get().Select(m => Mapper<B_Classe, H_Classe>.Map(m));
        }

        public H_Classe Get(int id)
        {
            return Mapper<B_Classe, H_Classe>.Map(ClasseService.Get(id));
        }
    }
}
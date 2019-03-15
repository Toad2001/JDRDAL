using JDRapi.Models;
using JDRBusiness.Models;
using JDRBusiness.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToolBox.MappeurGeneric;

namespace JDRapi.Services
{
    public class PJService
    {
        B_PJService pJService = new B_PJService();


        public IEnumerable<PJ> GetbyName(string name)
        {
            return pJService.GetbyName(name).Select(pj => Mapper<B_PJ, PJ>.Map(pj));
        }
    }
}
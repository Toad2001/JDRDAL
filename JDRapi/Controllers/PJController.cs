using JDRapi.Models;
using JDRapi.Services;
using JDRBusiness.Models;
using JDRBusiness.Services;
using JDRHelper.Models;
using JDRHelper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace JDRapi.Controllers
{
    [EnableCors(origins: "http://localhost:9935", headers: "*", methods: "*")]
    public class PJController : ApiController
    {
        private B_PJService pjService = new B_PJService();
        private PJService apipjService = new PJService();
        private B_RaceService raceService = new B_RaceService();
        private B_ClasseService classeService = new B_ClasseService();
        private B_SigneService signeService = new B_SigneService();


        // GET: api/PJ        
        public IEnumerable<PJ> Get()
        {
            IEnumerable<PJ> pjs = apipjService.Get();
            List<PJ> list = pjs.ToList();
            foreach (PJ item in list)
            {
                item.Race = raceService.Get(item.Id_Race);
                item.Classe = classeService.Get(item.Id_Classe);
                item.Signe = signeService.Get(item.Id_Signe);
            }
            return pjs;
        }

        // GET: api/PJ/5
        [HttpGet]
        public B_PJ Get(int id)
        {
            return pjService.Get(id);
        }

        // POST: api/PJ
        public void Post([FromBody]B_PJ value)
        {
            pjService.Insert(value);
        }

        // PUT: api/PJ/5
        public void Put(int id, [FromBody]B_PJ value)
        {
            pjService.Update(id, value);
        }

        // DELETE: api/PJ/5
        public void Delete(int id)
        {
            pjService.Delete(id);
        }
    }
}

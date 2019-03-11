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
    public class H_RaceService
    {
        B_RaceService raceService = new B_RaceService();

        public IEnumerable<H_Details> GetAll(int id)
        {
            H_Race h_race = Mapper<B_Race, H_Race>.Map(raceService.Get(id));
            return h_race.Details = (raceService.GetAll(h_race.Id).ToList()).ToHelper();
        }

        public IEnumerable<H_Race> Get()
        {
            return raceService.Get().Select(m => Mapper<B_Race, H_Race>.Map(m));
        }

        public H_Race Get(int id)
        {
            return Mapper<B_Race, H_Race>.Map(raceService.Get(id));
        }
    }
}
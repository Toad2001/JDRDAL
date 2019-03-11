using JDRBusiness.Models;
using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDRHelper.Mappers
{
    internal static class H_DetailMapper
    {
        internal static B_Details ToBDetail(this H_Details entity)
        {
            return new B_Details() { NomStat = entity.NomStat, ValeurStat = entity.ValeurStat };
        }

        internal static H_Details ToHDetail(this B_Details entity)
        {
            return new H_Details() { NomStat = entity.NomStat, ValeurStat = entity.ValeurStat };
        }

        internal static List<B_Details> ToHelper(this List<H_Details> entity)
        {
            List<B_Details> list = new List<B_Details>();

            foreach (H_Details item in entity)
            {
                list.Add(item.ToBDetail());
            }

            return list;
        }

        internal static List<H_Details> ToHelper(this List<B_Details> entity)
        {
            List<H_Details> list = new List<H_Details>();

            foreach (B_Details item in entity)
            {
                list.Add(item.ToHDetail());
            }

            return list;
        }
    }
}
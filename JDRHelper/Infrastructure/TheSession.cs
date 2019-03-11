using JDRHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDRHelper.Infrastructure
{
    public static class TheSession
    {
        public static H_Utilisateur CurrentUser
        {
            get { return (H_Utilisateur)HttpContext.Current.Session["Utilisateur"]; }
            set { HttpContext.Current.Session["Utilisateur"] = value; }
        }
    }
}
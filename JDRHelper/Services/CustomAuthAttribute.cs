using JDRBusiness.Services;
using JDRHelper.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JDRHelper.Services
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {
        B_RolesService rs = new B_RolesService();

        private string[] _roleAuth;

        //Crée un tableau contenant les roles
        public CustomAuthAttribute(params string[] roles)
        {          
            _roleAuth = roles;/**/
        }

        //On redéfinit la méthode OnAuthorization
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //Si ma session user est null ou que son role n'est pas dans la liste des role on redirige
            if (TheSession.CurrentUser == null || !_roleAuth.Contains(TheSession.CurrentUser.Role))
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    //Vers quelle action je vais renvoyer
                    { "action","Index" },
                    { "controller","Home" },
                    {"Area", string.Empty }

                });
            }
        }
    }
}
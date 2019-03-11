using JDRBusiness.Services;
using JDRHelper.Mappers;
using JDRHelper.Models;
using JDRHelper.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToolBox.Pattern.Repository;

namespace JDRHelper.Services
{
    public class H_UtilisateurService : IRepository<int, H_Utilisateur>
    {
        B_UtilisateurService us = new B_UtilisateurService();

        public IEnumerable<H_Utilisateur> Get()
        {
            return us.Get().Select(u => u.ToASPUtilisateur());
        }

        public H_Utilisateur Get(int id)
        {
            return us.Get(id).ToASPUtilisateur();
        }

        public H_Utilisateur Insert(H_Utilisateur entity)
        {
            return us.Insert(entity.ToBuisnessUtilisateur()).ToASPUtilisateur();
        }

        public bool Update(int id, H_Utilisateur entity)
        {
            return us.Update(id,entity.ToBuisnessUtilisateur());
        }

        public bool Delete(int id)
        {
            return us.Delete(id);
        }

        public H_Utilisateur CheckUser(LoginViewModel entity)
        {
            return us.Get().Select(u => u.ToASPUtilisateur()).Where(u => u.Email == entity.Email && u.Password == entity.Password).FirstOrDefault();
        }
    }
}
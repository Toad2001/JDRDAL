using JDRBusiness.Models;
using JDRBusiness.Services;
using JDRHelper.Infrastructure;
using JDRHelper.Mappers;
using JDRHelper.Models;
using JDRHelper.Models.ViewModel;
using JDRHelper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace JDRHelper.Controllers
{
    public class UtilisateurController : Controller
    {
        H_UtilisateurService us = new H_UtilisateurService();
        H_PJService pjs = new H_PJService();
        B_Role_UtilisateurService brs = new B_Role_UtilisateurService();

        #region Contact
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View(new ContactViewModel());
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel entity)
        {
            if (!ModelState.IsValid)
            {
                return View(entity);
            }
            if (entity != null)
            {
                SendMail(entity);
            }

            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Register
        [HttpGet]
        public ActionResult Register()
        {
            return View(new H_Utilisateur());
        }

        [HttpPost]
        public ActionResult Register(H_Utilisateur entity)
        {
            if (!ModelState.IsValid)
            {
                return View(entity);
            }

            B_Role_Utilisateur role_Utilisateur = new B_Role_Utilisateur();



            role_Utilisateur.Id_Role = 2;
            role_Utilisateur.Id_Utilisateur = us.Insert(entity).Id;

            brs.Insert(role_Utilisateur);

            return RedirectToAction("Connection");
        }
        #endregion

        #region Connection
        [HttpGet]
        public ActionResult Connection()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public ActionResult Connection(LoginViewModel entity)
        {
            if (!ModelState.IsValid)
            {
                return View(entity);
            }
            //getall des tes users avec linq pour ne prendre que celui qui a l'email en param            

            H_Utilisateur utilisateur = us.Get().Where(u => u.Email == entity.Email && u.Password == entity.Password).FirstOrDefault();
            // verif si null ou pas.
            if (utilisateur != null)
            {
                /* si pas null -> regarder si password est le même */

                /*si tout est ok -> mettre en session le user*/
                TheSession.CurrentUser = utilisateur;

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Contenu Incorrect";
                return View(utilisateur);
            }
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
        #endregion

        public static bool SendMail(ContactViewModel entity)
        {
            if (String.IsNullOrEmpty(entity.Message))
            {
                return false;
            }
            try
            {
                MailMessage mail = new MailMessage();

                mail.To.Add("JdrHelper2019@gmail.com");
                mail.From = new MailAddress(entity.Email);
                mail.Subject = entity.Objet;
                mail.Body = entity.Message;
                mail.SubjectEncoding = Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.Normal;
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.Credentials = new NetworkCredential("JdrHelper2019@gmail.com", "JdrHelper1234");
                client.Port = 587;

                client.EnableSsl = true;
                client.Send(mail);
                return true;

            }
            catch (Exception)
            {
                throw new Exception("L'envoi de mail ne c'est pas passsé comme prévu...");
            }
        }
    }
}
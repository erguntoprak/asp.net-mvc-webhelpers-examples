using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebHelpers.Controllers
{
    public class WebMailController : Controller
    {

#region WebMail
        public ActionResult Index()
        {
            bool sonuc = false;
            WebMail.SmtpServer = "smtp.gmail.com";
            WebMail.SmtpPort = 587;
            WebMail.UserName = "mailadresin@gmail.com";
            WebMail.Password = "şifre";
            WebMail.EnableSsl = true;
            string file = Server.MapPath("~/Content/Files/Deneme_Word.docx");
            try
            {
                WebMail.Send(
                    to: "ergun_55555@hotmail.com",
                    subject: "Merhaba",
                    body: "Deneme Mail'lidir.Asp.Net MVC'de <strong>WebMail</strong> kullanarak atılmıştır",
                    isBodyHtml: true,
                    filesToAttach: new[] { file }
                    );
                ViewBag.Success = !sonuc;
            }
            catch (Exception)
            {
                ViewBag.Success = sonuc;
                
            }
            return View();
        }
#endregion

    }
}
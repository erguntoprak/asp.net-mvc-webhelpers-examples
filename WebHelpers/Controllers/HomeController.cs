using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHelpers.Models;

namespace WebHelpers.Controllers
{
    public class HomeController : Controller
    {
#region @Html.AntiForgeryToken Kullanımı
        public static List<string> yemekListesi = new List<string> {"Dolma","Sarma","Kızartma","Kebab","Adana Dürüm" };

        public object Ogreci { get; private set; }

        public ActionResult Index()
        {
            return View(yemekListesi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(int id)
        {
            yemekListesi.RemoveAt(id);
            return RedirectToAction("Index");
        }
        //Burda deneme yapıyoruz index sayfasına gitmeden silme işlemi gerçekleşcekmi diye ve gerçeklisti.Çünkü biz burda 
        //@Html.AntiForgeryToken ile bir anahtar oluşturulması yapmadan deneme sini yapytık
        public ActionResult DenemeAction()
        {
            return View();
        }
        #endregion

#region Grid Kullanımı
        public ActionResult WebHelpersGrid()
        {
            Ogrenci.FakeVeriOlustur(50);
            return View(Ogrenci.Ogrenciler);
        }
#endregion
    }
}
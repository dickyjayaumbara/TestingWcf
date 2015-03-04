using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteConsumeWCF.Controllers
{
    public class ServiceWCFController : Controller
    {
        //
        // GET: /ServiceWCF/

        public ActionResult Index(decimal? hasil, decimal? angkaPertama, decimal? angkaKedua)
        {
            if (hasil.HasValue)
            {
                ViewData["angkaPertama"] = angkaPertama;
                ViewData["angkaKedua"] = angkaKedua;
                ViewData["hasil"] = hasil;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Perhitungan(FormCollection form, string tipePerhitungan)
        {
            decimal angkaPertama = 0;
            decimal angkaKedua = 0;
            decimal hasilPerhitungan = 0;

            if (form["angkaPertamaStr"] != null)
            {
               angkaPertama = Convert.ToDecimal(form["angkaPertamaStr"]);
            }

            if (form["angkaKeduaStr"] != null)
            {
                angkaKedua = Convert.ToDecimal(form["angkaKeduaStr"]);
            }
            
            ServiceWCF.ServiceClientClient servWCF = new ServiceWCF.ServiceClientClient();

            switch (tipePerhitungan)
            {
                case "penjumlahan":
                    hasilPerhitungan = servWCF.Penjumlahan(angkaPertama, angkaKedua);
                    break;
                case "pengurangan":
                    hasilPerhitungan = servWCF.Pengurangan(angkaPertama, angkaKedua);
                    break;
                case "perkalian":
                    hasilPerhitungan = servWCF.Perkalian(angkaPertama, angkaKedua);
                    break;
                case "pembagian":
                    hasilPerhitungan = servWCF.Pembagian(angkaPertama, angkaKedua);
                    break;
            }

            return RedirectToAction("Index", new { hasil = hasilPerhitungan, angkaPertama = angkaPertama, angkaKedua = angkaKedua });
        }
    }
}

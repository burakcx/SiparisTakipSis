using SiparisTakip.Interfaces.StokIG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisTakip.AspNetMvcUI.Controllers
{
    public class KullaniciController : Controller
    {
        IStokService _StokService;

        public KullaniciController(IStokService StokService)
        {
            _StokService = StokService;
        }


        // GET: Kullanici
        [HttpGet]
        public ActionResult Index()
        {
            var data = _StokService.ListeGetir();


            return View(data);
        }
    }
}
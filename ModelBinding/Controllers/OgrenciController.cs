using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Controllers
{
    public class OgrenciController : Controller
    {
        OgrenciContext db = new OgrenciContext();
        public IActionResult Index()
        {
            var ogr = db.Ogrenci.ToList();
            return View(ogr);
        }
        public IActionResult OgrenciEkle()
        {

            return View();
        }

        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenci ogr)
        {

                db.Ogrenci.Add(ogr);
                db.SaveChanges();
                return View(db.Ogrenci);
        }
    }
}

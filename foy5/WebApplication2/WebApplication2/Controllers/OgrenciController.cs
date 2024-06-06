using WebApplication2.Services;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly ApplicationDbContext context;
        public OgrenciController(ApplicationDbContext context)
        {
            this.context = context;

        }
        public IActionResult Index()
        {
            var ogrenci = context.tOgrenci.OrderByDescending(p => p.ogrenciID).ToList();
            return View(ogrenci);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(OgrenciDto ogrenciDto)
        {
            if (!ModelState.IsValid)
            {
                return View(ogrenciDto);
            }

            Ogrenci ogrenci = new Ogrenci()
            {
                ogrenciID = ogrenciDto.ogrenciID,
                ad = ogrenciDto.ad,
                soyad = ogrenciDto.soyad,
                bolumID = ogrenciDto.bolumID,
            };

            context.tOgrenci.Add(ogrenci);
            context.SaveChanges();

            return RedirectToAction("Index", "Ogrenci");
        }

        public IActionResult Edit(int id)
        {
            var ogrenci = context.tOgrenci.Find(id);

            if (ogrenci == null)
            {
                return RedirectToAction("Index", "Ogrenci");
            }

            var ogrenciDto = new OgrenciDto()
            {
                ogrenciID = ogrenci.ogrenciID,
                ad = ogrenci.ad,
                soyad = ogrenci.soyad,
                bolumID = ogrenci.bolumID,
            };

            ViewData["ogrenciID"] = ogrenci.ogrenciID;
            ViewData["ad"] = ogrenci.ad;
            ViewData["soyad"] = ogrenci.soyad;
            ViewData["bolumID"] = ogrenci.bolumID;

            return View(ogrenciDto);
        }

        [HttpPost]
        public IActionResult Edit(int id, OgrenciDto ogrenciDto)
        {
            var ogrenci = context.tOgrenci.Find(id);

            if (ogrenci == null)
            {
                return RedirectToAction("Index", "Ogrenci");
            }

            if (!ModelState.IsValid)
            {
                ViewData["ogrenciID"] = ogrenci.ogrenciID;
                ViewData["ad"] = ogrenci.ad;
                ViewData["soyad"] = ogrenci.soyad;
                ViewData["bolumID"] = ogrenci.bolumID;

                return View(ogrenciDto);
            }

            ogrenci.ad = ogrenciDto.ad;
            ogrenci.soyad = ogrenciDto.soyad;
            ogrenci.bolumID = ogrenciDto.bolumID;

            context.SaveChanges();

            return RedirectToAction("Index", "Ogrenci");
        }

        public IActionResult Delete(int id)
        {
            var ogrenci = context.tOgrenci.Find(id);
            if (ogrenci == null)
            {
                return RedirectToAction("Index", "Ogrenci");
            }

            context.tOgrenci.Remove(ogrenci);
            context.SaveChanges(true);

            return RedirectToAction("Index", "Ogrenci");
        }

        /*public IActionResult Ara(int id)
        {
            var ogrenci = context.tOgrenciDers.Find(id);

            if (ogrenci == null)
            {
                return RedirectToAction("Index", "Ogrenci");
            }

            var ogrenciDto = new OgrenciDto()
            {
                ogrenciID = ogrenci.ogrenciID,
                ad = ogrenci.ad,
                soyad = ogrenci.soyad,
                bolumID = ogrenci.bolumID,
            };

            ViewData["ogrenciID"] = ogrenci.ogrenciID;
            ViewData["ad"] = ogrenci.ad;
            ViewData["soyad"] = ogrenci.soyad;
            ViewData["bolumID"] = ogrenci.bolumID;

            return View(ogrenciDto);
        }*/
    }
}

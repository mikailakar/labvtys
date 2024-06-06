using WebApplication2.Services;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BolumController : Controller
    {
        private readonly ApplicationDbContext context;
        public BolumController(ApplicationDbContext context) {
            this.context = context;

        }
        public IActionResult Index()
        {
            var bolum = context.tBolum.OrderByDescending(p => p.bolumID).ToList();
            return View(bolum);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BolumDto bolumDto)
        {
            if (!ModelState.IsValid)
            {
                return View(bolumDto);
            }

            Bolum bolum = new Bolum()
            {
                bolumID = bolumDto.bolumID,
                bolumAd = bolumDto.bolumAd,
                fakulteID = bolumDto.fakulteID,
            };

            context.tBolum.Add(bolum);
            context.SaveChanges();

            return RedirectToAction("Index", "Bolum");
        }

        public IActionResult Edit(int id)
        {
            var bolum = context.tBolum.Find(id);

            if (bolum == null)
            {
                return RedirectToAction("Index", "Bolum");
            }

            var bolumDto = new BolumDto()
            {
                bolumID = bolum.bolumID,
                bolumAd = bolum.bolumAd,
                fakulteID = bolum.fakulteID,
            };

            ViewData["bolumID"] = bolum.bolumID;
            ViewData["bolumAd"] = bolum.bolumAd;
            ViewData["fakulteID"] = bolum.fakulteID;

            return View(bolumDto);
        }

        [HttpPost]
        public IActionResult Edit(int id, BolumDto bolumDto)
        {
            var bolum = context.tBolum.Find(id);

            if (bolum == null)
            {
                return RedirectToAction("Index", "Bolum");
            }

            if (!ModelState.IsValid)
            {
                ViewData["bolumID"] = bolum.bolumID;
                ViewData["bolumAd"] = bolum.bolumAd;
                ViewData["fakulteID"] = bolum.fakulteID;

                return View(bolumDto);
            }

            bolum.bolumAd = bolumDto.bolumAd;
            bolum.fakulteID = bolumDto.fakulteID;

            context.SaveChanges();

            return RedirectToAction("Index", "Bolum");
        }

        public IActionResult Delete(int id)
        {
            var bolum = context.tBolum.Find(id);
            if (bolum == null)
            {
                return RedirectToAction("Index", "Bolum");
            }

            context.tBolum.Remove(bolum);
            context.SaveChanges(true);

            return RedirectToAction("Index", "Bolum");
        }
    }
}

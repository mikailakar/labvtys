using WebApplication2.Services;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class FakulteController : Controller
    {
        private readonly ApplicationDbContext context;
        public FakulteController(ApplicationDbContext context) {
            this.context = context;
            
        }
        public IActionResult Index()
        {
            var fakulte = context.tFakulte.OrderByDescending(p => p.fakulteID).ToList();
            return View(fakulte);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FakulteDto fakulteDto)
        {
            if (!ModelState.IsValid)
            {
                return View(fakulteDto);
            }

            Fakulte fakulte = new Fakulte()
            {
                fakulteID = fakulteDto.fakulteID,
                fakulteAd = fakulteDto.fakulteAd,
            };

            context.tFakulte.Add(fakulte);
            context.SaveChanges();

            return RedirectToAction("Index", "Fakulte");
        }

        public IActionResult Edit(int id)
        {
            var fakulte = context.tFakulte.Find(id);

            if (fakulte == null)
            {
                return RedirectToAction("Index", "Fakulte");
            }

            var fakulteDto = new FakulteDto()
            {
                fakulteID = fakulte.fakulteID,
                fakulteAd = fakulte.fakulteAd,
            };

            ViewData["fakulteID"] = fakulte.fakulteID;
            ViewData["fakulteAd"] = fakulte.fakulteAd;

            return View(fakulteDto);
        }

        [HttpPost]
        public IActionResult Edit(int id, FakulteDto fakulteDto)
        {
            var fakulte = context.tFakulte.Find(id);

            if(fakulte == null)
            {
                return RedirectToAction("Index", "Fakulte");
            }

            if (!ModelState.IsValid)
            {
                ViewData["fakulteID"] = fakulte.fakulteID;
                ViewData["fakulteAd"] = fakulte.fakulteAd;

                return View(fakulteDto);
            }

            fakulte.fakulteAd = fakulteDto.fakulteAd;

            context.SaveChanges();

            return RedirectToAction("Index", "Fakulte");
        }

        public IActionResult Delete(int id)
        {
            var fakulte = context.tFakulte.Find(id);
            if(fakulte == null)
            {
                return RedirectToAction("Index", "Fakulte");
            }

            context.tFakulte.Remove(fakulte);
            context.SaveChanges(true);

            return RedirectToAction("Index", "Fakulte");
        }
    }
}

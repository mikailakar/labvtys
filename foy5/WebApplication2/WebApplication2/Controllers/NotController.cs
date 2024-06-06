using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class NotController : Controller
    {
        private readonly ApplicationDbContext context;
        public NotController(ApplicationDbContext context)
        {
            this.context = context;

        }
        public IActionResult Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var members = from mem in context.tOgrenciDers
                          select mem;
            if (!String.IsNullOrEmpty(searchString))
            {
                members = members.Where(m => m.dersID.ToString().Contains(searchString));
                return View(members);
            }

            var memberList = context.tOgrenciDers.ToList();
            return View(memberList);
        }

        public IActionResult Edit(int id)
        {
            var ogrenciDers = context.tOgrenciDers.Find(id);

            if (ogrenciDers == null)
            {
                return RedirectToAction("Index", "OgrenciDers");
            }

            var ogrenciDersDto = new OgrenciDersDto()
            {
                ogrenciID = ogrenciDers.ogrenciID,
                dersID = ogrenciDers.dersID,
                vize = ogrenciDers.vize,
                final = ogrenciDers.final,
            };

            ViewData["dersID"] = ogrenciDers.dersID;
            ViewData["ogrenciID"] = ogrenciDers.ogrenciID;
            ViewData["vize"] = ogrenciDers.vize;
            ViewData["final"] = ogrenciDers.final;

            return View(ogrenciDersDto);
        }

        [HttpPost]
        public IActionResult Edit(int id, OgrenciDersDto ogrenciDersDto)
        {
            var ogrenciDers = context.tOgrenciDers.Find(id);

            if (ogrenciDers == null)
            {
                return RedirectToAction("Index", "Not");
            }

            if (!ModelState.IsValid)
            {
                ViewData["ogrenciDersID"] = ogrenciDers.ogrenciDersID;
                ViewData["ogrenciID"] = ogrenciDers.ogrenciID;
                ViewData["dersID"] = ogrenciDers.dersID;
                ViewData["vize"] = ogrenciDers.vize;
                ViewData["final"] = ogrenciDers.final;

                return View(ogrenciDersDto);
            }

            ogrenciDers.vize = ogrenciDersDto.vize;
            ogrenciDers.final = ogrenciDersDto.final;

            context.SaveChanges();

            return RedirectToAction("Index", "Not", new { searchString = ogrenciDers.dersID });
        }
    }
}

using WebApplication2.Services;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class OgrenciDersController : Controller
    {
        private readonly ApplicationDbContext context;
        public OgrenciDersController(ApplicationDbContext context)
        {
            this.context = context;

        }
        /*public IActionResult Index()
        {
            var ogrenciders = context.tOgrenciDers.OrderByDescending(p => p.ogrenciDersID).OrderByDescending(p => p.ogrenciDersID).ToList();
            return View(ogrenciders);
        }*/

        public IActionResult Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var members = from mem in context.tOgrenciDers
                          select mem;
            if (!String.IsNullOrEmpty(searchString))
            {
                members = members.Where(m => m.ogrenciID.ToString().Contains(searchString));
                return View(members);
            }

            var memberList = context.tOgrenciDers.ToList();
            return View(memberList);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(OgrenciDersDto ogrenciDersDto)
        {
            if (!ModelState.IsValid)
            {
                return View(ogrenciDersDto);
            }

            OgrenciDers ogrenciDers = new OgrenciDers()
            {
                ogrenciID = ogrenciDersDto.ogrenciID,
                dersID = ogrenciDersDto.dersID,
                yil = ogrenciDersDto.yil,
                yariyil = ogrenciDersDto.yariyil,
                vize = ogrenciDersDto.vize,
                final = ogrenciDersDto.final,
            };

            context.tOgrenciDers.Add(ogrenciDers);
            context.SaveChanges();

            return RedirectToAction("Index", "OgrenciDers");
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
                yil = ogrenciDers.yil,
                yariyil = ogrenciDers.yariyil,
                vize = ogrenciDers.vize,
                final = ogrenciDers.final,
            };

            ViewData["ogrenciDersID"] = ogrenciDers.ogrenciDersID;
            ViewData["ogrenciID"] = ogrenciDers.ogrenciID;
            ViewData["dersID"] = ogrenciDers.dersID;
            ViewData["yil"] = ogrenciDers.yil;
            ViewData["yariyil"] = ogrenciDers.yariyil;
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
                return RedirectToAction("Index", "OgrenciDers");
            }

            if (!ModelState.IsValid)
            {
                ViewData["ogrenciDersID"] = ogrenciDers.ogrenciDersID;
                ViewData["ogrenciID"] = ogrenciDers.ogrenciID;
                ViewData["dersID"] = ogrenciDers.dersID;
                ViewData["yil"] = ogrenciDers.yil;
                ViewData["yariyil"] = ogrenciDers.yariyil;
                //ViewData["vize"] = ogrenciDers.vize;
                //ViewData["final"] = ogrenciDers.final;

                return View(ogrenciDersDto);
            }

            ogrenciDers.dersID = ogrenciDersDto.dersID;
            ogrenciDers.yil = ogrenciDersDto.yil;
            ogrenciDers.yariyil = ogrenciDersDto.yariyil;
            //ogrenciDers.vize = ogrenciDersDto.vize;
            //ogrenciDers.final = ogrenciDersDto.final;

            context.SaveChanges();

            return RedirectToAction("Index", "OgrenciDers");
        }

        public IActionResult Delete(int id)
        {
            var ogrenciDers = context.tOgrenciDers.Find(id);
            if (ogrenciDers == null)
            {
                return RedirectToAction("Index", "ogrenciDers");
            }

            context.tOgrenciDers.Remove(ogrenciDers);
            context.SaveChanges(true);

            return RedirectToAction("Index", "OgrenciDers");
        }
    }
}

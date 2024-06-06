using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DersController : Controller
    {
        private readonly ApplicationDbContext context;
        public DersController(ApplicationDbContext context)
        {
            this.context = context;

        }

        public IActionResult Index(string searchString, string searchStringt)
        {
            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentFiltert"] = searchStringt;

            var members = from mem in context.tOgrenciDers
                          select mem;
            if (!String.IsNullOrEmpty(searchString) && !String.IsNullOrEmpty(searchStringt))
            {
                members = members.Where(m => m.yil.ToString().Contains(searchString) && m.yariyil.ToString().Contains(searchStringt));
                var groupmember = members.GroupBy(m => new { m.dersID, m.yil, m.yariyil}).
                    Select(Group => new OgrenciDers{dersID=Group.Key.dersID, yil=Group.Key.yil, yariyil=Group.Key.yariyil, vize=Group.Count()})
                    .OrderByDescending(p => p.yil).ThenBy(p => p.yariyil).ThenBy(p => p.dersID).ToList();
                return View(groupmember);
            }
            else if (!String.IsNullOrEmpty(searchString))
            {
                members = members.Where(m => m.yil.ToString().Contains(searchString));
                var groupmember = members.GroupBy(m => new { m.dersID, m.yil, m.yariyil }).
                    Select(Group => new OgrenciDers { dersID = Group.Key.dersID, yil = Group.Key.yil, yariyil = Group.Key.yariyil, vize = Group.Count() })
                    .OrderByDescending(p => p.yil).ThenBy(p => p.yariyil).ThenBy(p => p.dersID).ToList();
                return View(groupmember);
            }
            else if (!String.IsNullOrEmpty(searchStringt))
            {
                members = members.Where(m => m.yariyil.ToString().Contains(searchStringt));
                var groupmember = members.GroupBy(m => new { m.dersID, m.yil, m.yariyil }).
                    Select(Group => new OgrenciDers { dersID = Group.Key.dersID, yil = Group.Key.yil, yariyil = Group.Key.yariyil, vize = Group.Count() })
                    .OrderByDescending(p => p.yil).ThenBy(p => p.yariyil).ThenBy(p => p.dersID).ToList();
                return View(groupmember);
            }

            var memberList = members.GroupBy(m => new { m.dersID, m.yil, m.yariyil }).
                    Select(Group => new OgrenciDers { dersID = Group.Key.dersID, yil = Group.Key.yil, yariyil = Group.Key.yariyil, vize = Group.Count() })
                    .OrderByDescending(p => p.yil).ThenBy(p => p.yariyil).ThenBy(p => p.dersID).ToList();
            return View(memberList);
        }
    }
}

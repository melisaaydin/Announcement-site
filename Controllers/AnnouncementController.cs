using Microsoft.AspNetCore.Mvc;
using Homework.Models;
namespace Homework.Controllers
{
    public class AnnouncementController : Controller
    {

        public IActionResult Announce()
        {
            var announcements = Repository.Announcements;

            return View(announcements);
        }

        public IActionResult AddAnnounce()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddAnnounce([FromForm] Announcement model)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Home/Index", model);

            }
            return View();
        }
        //[HttpPost]

        public IActionResult AddedAnnouncement([FromForm] Announcement models)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(models);
                return View("AddedAnnouncement", models);

            }
            return View();

        }

        public IActionResult Details(int id)
        {
            var announcement = Repository.Announcements.FirstOrDefault(a => a.Id == id);
            if (announcement == null)
            {
                return NotFound();
            }
            return View(announcement);
        }


    }
}
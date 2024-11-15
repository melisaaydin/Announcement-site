using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Homework.Models;
using Microsoft.AspNetCore.DataProtection.Repositories;

namespace Homework.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View(Repository.Announcements);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}



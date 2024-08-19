using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Biblioteca_Virtual.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

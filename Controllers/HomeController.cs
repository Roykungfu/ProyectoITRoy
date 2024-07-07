using Microsoft.AspNetCore.Mvc;
using ProyectoIT.Models;
using System.Diagnostics;

namespace ProyectoIT.Controllers
{

// El controlador es un intermediario entre lo que ve el usuario y lo que recolecta de la base de datos


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() // IActionResult es el resultado de la accion del controlador, es una forma flexible de devolver datos HTTP
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

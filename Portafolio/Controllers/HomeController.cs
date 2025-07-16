using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyecto proyectos;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyecto proyectos)
        {
            _logger = logger;
            this.proyectos = proyectos;
        }

        public IActionResult Index()
        {
            var listaProyectos = proyectos.ObtenerProyectos();
            var modelo = new HomeIndexViewModel() { Proyectos = listaProyectos };
            return View(modelo);
        }

        public IActionResult Proyectos()
        {
            var proyectosModelo = proyectos.ObtenerProyectos();
            return View(proyectosModelo);
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

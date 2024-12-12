using System.Diagnostics;
using estructura_pagina.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eva2ti_EduardoMartinez.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Lista de imágenes dinámicas
        public ActionResult IndexImage()
        {
            var images = new List<imageMolde>
            {
                new imageMolde { Id = 1, Title = "Tatuador Profesional", ImagePath = "/images/tatuador_alejandro.jpg" },
                new imageMolde { Id = 2, Title = "Máquina de Tatuaje", ImagePath = "/images/maquina-tattoo.jpg" },
                new imageMolde { Id = 3, Title = "Agujas para Tatuaje", ImagePath = "/images/ajugas_tatto.jpg" },
            };

            return View(images);
        }

        public IActionResult Contacto()
        {
            return View("/Views/formularios/vista_contacto.cshtml");
        }
        public IActionResult agregar()
        {
            return View("/Views/formularios/agregar_productos.cshtml");
        }
        public IActionResult perfiles()
        {
            return View("/Views/formularios/perfil_usuarios.cshtml");
        }
        public IActionResult despacho()
        {
            return View("/Views/formularios/despacho.cshtml");
        }
        public IActionResult proveedor()
        {
            return View("/Views/formularios/proveedor.cshtml");
        }
        public IActionResult Login()
        {
            return View("/Views/formularios/vista_login.cshtml");
        }
        public IActionResult recuperacion()
        {
            return View("/Views/formularios/recuperacion_contraseña.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP5_SaladeEscape.Models;

namespace TP5_SaladeEscape.Controllers;

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
    public IActionResult Tutorial()
    {
        return View();
    }
    public IActionResult Creditos()
    {
        return View();
    }
    public IActionResult Comenzar()
    {
        return View("Habitacion" + Escape.GetEstadoJuego());
    }
    public IActionResult Habitacion(int sala, string clave)
    {
        bool ok= Escape.ResolverSala(sala, clave);
        if (!ok){
            ViewBag.paso = "no";
        } else {
            ViewBag.paso = "si";
        }
        //ViewBag.Pista1 = Escape.matPistas[Escape.GetEstadoJuego(),0];
        //ViewBag.Pista2 = Escape.matPistas[Escape.GetEstadoJuego(),1];
        //ViewBag.Pista3 = Escape.matPistas[Escape.GetEstadoJuego(),2];
        return View("Habitacion" + Escape.GetEstadoJuego());
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

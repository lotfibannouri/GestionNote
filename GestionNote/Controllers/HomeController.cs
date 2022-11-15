using GestionNote.Models;
using GestionNote.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestionNote.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEtudiantService _EtudiantService;

        public HomeController(IEtudiantService etudiantService)
        {
            _EtudiantService = etudiantService;
        }

        public IActionResult Index()
        {
            var listEtduiant = _EtudiantService.GetEtudiants();
            if (TempData["Message"] != null)
                ViewBag.DpMessage = TempData["Message"];
            if (TempData["ErrorMessage"] != null)
            {
                ViewBag.errorMessage = TempData["ErrorMessage"];
            }
            return View(listEtduiant);
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
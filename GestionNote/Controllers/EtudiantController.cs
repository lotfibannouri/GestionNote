using GestionNote.Models;
using GestionNote.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestionNote.Controllers
{
    public class EtudiantController : Controller
    {
        private readonly IEtudiantService _EtudiantService;
        public EtudiantController(IEtudiantService etudiantService)
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
        [HttpPost]
        public IActionResult AddEtudiant(Etudiant etudiant)
        {
            var rest = _EtudiantService.AddEtudiant(etudiant);
            if (rest)
                TempData["Message"] = "Etudiant enregistrer avec succées";

            else
                TempData["ErrorMessage"] = "Erreur d'enregistrement vérifier avec l'administrateur";
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            Etudiant etudiant = _EtudiantService.GetEtudiantById(id);
            return View(etudiant);
        }
        [HttpPut]
        public IActionResult Edit(Etudiant model)
        {


            Etudiant etudiant = _EtudiantService.GetEtudiantById(model.ID);
            etudiant.Nom = model.Nom;
            etudiant.Prenom = model.Prenom;


            var rst = _EtudiantService.EditEtudiant(etudiant);
            if (rst)

                TempData["Message"] = "Utilsateur Modifier avec succée";


            else

                TempData["ErrorMessage"] = "Erreur dans la modification de l'Etudiant";




            return RedirectToAction("Index");
        }
      
        public IActionResult Delete(int id)
        {
            var rst = _EtudiantService.RemoveEtudiant(id);
            if (rst == true)
            {
                TempData["Message"] = "Utilsateur Supprimer avec succée";
            }
            else
            {
                TempData["ErrorMessage"] = "Erreur dans la Suppression de l'utilisateur";
            }

            return RedirectToAction("Index");
        }


    }
}

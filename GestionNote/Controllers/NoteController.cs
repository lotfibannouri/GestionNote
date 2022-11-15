using Microsoft.AspNetCore.Mvc;

namespace GestionNote.Controllers
{
    public class NoteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

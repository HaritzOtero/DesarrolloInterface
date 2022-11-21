using Microsoft.AspNetCore.Mvc;

namespace Adibidea.Controllers
{
    public class KaixoMunduaController : Controller
    {
        public IActionResult OngiEtorri(String izena, int zenbat =1)
        {
            ViewBag.Mezua = "Hello" + izena;
            ViewBag.Zenbat = zenbat;
            return View();
        }


        
        
    }
}

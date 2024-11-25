using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAjaxContent()
           
        {
           return PartialView("Partials/_ContentPartial");
        }
        public IActionResult Products()
        {
            var products = new List<object>
            {
                new { Id = 1, Name = "Solaria Tech" , Description = "En innovativ startup som utvecklar solcellsdrivna teknologiska l�sningar f�r framtidens energibehov."  },
                new { Id = 2, Name = "Nordic Wanderer" , Description = "En reseblogg med fokus p� natursk�na destinationer i Norden, med tips f�r �ventyrare och natur�lskare." },
                new { Id = 3, Name = "PixelCraft Studio" , Description = "Ett kreativt designf�retag som specialiserar sig p� grafik och animationer f�r digitala plattformar."},
                new { Id = 4, Name = "Harmony Brew" , Description = "En hantverksbryggeri som kombinerar traditionella bryggmetoder med moderna smaker." },
                new { Id = 5, Name = "AquaSphere Innovations" , Description = "Ett milj�teknikf�retag som utvecklar l�sningar f�r att rena och �teranv�nda vatten i urbana milj�er." }
            };
            return Json(products);
    


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

using Microsoft.AspNetCore.Mvc;
using projetbdtnS8.Models;
using System.Diagnostics;

namespace projetbdtnS8.Controllers
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



        [HttpPost]
        public ActionResult form1(int txtId, string txtName, string chkAddon)
        {
            //informations de l'epc 100

            //informations de l'epc 101

            //information de l'epc 102
            ViewBag.epc101 = "in";
            ViewBag.Id = txtId;
            ViewBag.Name = txtName;
            if (chkAddon != null)
                ViewBag.Addon = "Selected";
            else
                ViewBag.Addon = "Not Selected";

            return View("Index45");
        }


        [HttpPost]
        public ActionResult formanalytique(int txtId, string epc, string time)
        {
            //informations de l'epc 100

            //informations de l'epc 101

            //information de l'epc 102
            ViewBag.epc101 = "in";
            ViewBag.Id = txtId;
            ViewBag.Name = epc;
            ViewBag.heure = time;
            if (epc == "epc_100")
            {
                if (time == "18:35:00")
                {
                    ViewBag.resultat = "dans la zone in";
                }
                else if (time == "18:35:10")
                {
                    ViewBag.resultat = "dans la zone in";
                }
                else if (time == "18:35:20")
                {
                    ViewBag.resultat = "dans la zone in";
                }
                /**ViewBag.resultat = "dans la zone in";
                ViewBag.resultat = "avant la zone in";
                ViewBag.resultat = "après la zone in";*/
            }
                
            else if(epc == "epc_101")
            {
                if(time== "18:35:00")
                {
                    ViewBag.resultat = "dans la zone in";
                }
                else if (time == "18:35:10")
                {
                    ViewBag.resultat = "dans la zone in";
                }
                else if (time == "18:35:20")
                {
                    ViewBag.resultat = "dans la zone in";
                }
                

            }
            else if (epc == "epc_102")
            {
                if (time == "18:35:00")
                {

                }
                else if (time == "18:35:10")
                {

                }
                else if (time == "18:35:20")
                {

                }

            }


            return View("Analytique");
        }





        public IActionResult About()
        {
            return View();
        }

        public IActionResult Analytique()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Index45()
        {
            return View();
        }


        public IActionResult Statistique()
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
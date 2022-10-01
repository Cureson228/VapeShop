using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VapeShop.Models;

namespace VapeShop.Controllers
{
    
    public class HomeController : Controller
    {
        

        [Route("/main")]
        [Route("")]
        public IActionResult Main()
        {
            return View("Main");
        }


        [Route("/garanty")]
        public IActionResult Garanty()
        {
            return View();
        }

        [Route("/dostavka")]
        public IActionResult Deliverence()
        {
            return View();
        }

        [Route("/contact")]
        public IActionResult Contacts()
        {
            return View();
        }
        
    }
}
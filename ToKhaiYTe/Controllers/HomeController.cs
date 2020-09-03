using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToKhaiYTe.Models;
using ToKhaiYTe.Models.Service;

namespace ToKhaiYTe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHealthDeclarationService service;

        public HomeController(ILogger<HomeController> logger, IHealthDeclarationService service)
        {
            _logger = logger;
            this.service = service;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(MDFViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                service.SaveHealthDeclarationForm(model);
                return RedirectToAction("CompleteCreate");
            }
            
            return RedirectToAction("FailCreate");
        }
        public IActionResult CompleteCreate()
        {
            return View();
        }
        public IActionResult FailCreate()
        {
            return View();
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

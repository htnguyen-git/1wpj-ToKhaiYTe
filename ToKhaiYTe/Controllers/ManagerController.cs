using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToKhaiYTe.Models;
using ToKhaiYTe.Models.Service;

namespace ToKhaiYTe.Controllers
{
    /*[Authorize]*/
    public class ManagerController : Controller
    {
        private readonly IHealthDeclarationService healthDeclarationService;

        public ManagerController(IHealthDeclarationService healthDeclarationService)
        {
            this.healthDeclarationService = healthDeclarationService;
        }
        public IActionResult Index()
        {
            var model = healthDeclarationService.GetsManagerIndexViewModel();
            return View(model);
        }
        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }
    }
}

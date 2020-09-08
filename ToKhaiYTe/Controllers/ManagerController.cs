using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToKhaiYTe.Models.Service;
using ToKhaiYTe.Models.ViewModel;

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
        public IActionResult GetFullInfo(int Id)
        {
            ManagerFullInfoViewModel data = healthDeclarationService.GetInfo(Id);
            if (data.MedicalDeclarationForm is null)
            {
                ViewBag.Status = $"Không tìm thấy thông tin của id {Id}";
                return View();
            }
            return View(data);
        }
        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(ManagerSearchViewModel model)
        {
            List<ManagerIndexViewModel> list = new List<ManagerIndexViewModel>();
            if (ModelState.IsValid)
            {
                 list.AddRange(healthDeclarationService.Search(model));
                
            }
            if (list != null)
            {
                
                return View("Index", list);
            }
            ViewBag.Status = $"Hãy kiểm tra lại từ khóa và đảm bảo đã tick vào ít nhất 1 lựa chọn";
            return View("Index");
        }


    }
}

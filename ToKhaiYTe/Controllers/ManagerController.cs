using Microsoft.AspNetCore.Mvc;
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
        /*[HttpPost]
        public IActionResult Search(ManagerSearchViewModel model)
        {
            if (true)
            {

            }
        }*/
        
        
    }
}

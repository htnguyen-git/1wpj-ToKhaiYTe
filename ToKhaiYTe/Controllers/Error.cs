using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToKhaiYTe.Controllers
{
    public class Error : Controller
    {
        [Route("error/{StatusCode}")]
        public IActionResult PageNotFound(int StatusCode)
        {
            return View(StatusCode);
        }
    }
}

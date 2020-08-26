using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToKhaiYTe.Models;

namespace ToKhaiYTe.Controllers
{
    public class HelperController : Controller
    {
        
        public JsonResult GetListGender()
        {
            string[] listGender = { "Nam","Nữ","Khác" };
            return Json(new{listGender});
            
        }
    }
}

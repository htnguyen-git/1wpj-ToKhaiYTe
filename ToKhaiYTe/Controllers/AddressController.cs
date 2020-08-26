using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToKhaiYTe.Models.AddressInfo;

namespace ToKhaiYTe.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressRepository contextAddress;

        public AddressController( IAddressRepository ContextAddress)
        {
            contextAddress = ContextAddress;
        }
        
        public JsonResult GetListCountry()
        {
            var listCountry = contextAddress.GetCountry();
            return Json(new { listCountry }) ;
        }
        [Route("address/GetListGate")]
        public JsonResult GetListGate()
        {
            var listGate = contextAddress.GetGates();
            return Json(new { listGate });
        }
       
        public JsonResult GetListNational()
        {
            var listNational = contextAddress.GetCountry();
            return Json(new { listNational});
        }
        [Route("Address/GetListProvince/")]
        public JsonResult GetListProvince()
        {
            var listProvince = contextAddress.GetProvince();
            return Json(new {listProvince });
        }
    }
}

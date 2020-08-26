using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models.AddressInfo
{
    public interface IAddressRepository
    {
       Task<  IEnumerable<Country>> GetCountry();
       Task< IEnumerable<Province>> GetProvince();
       Task< IEnumerable<District>> GetDistricts(int ProvinceId);
       Task< IEnumerable<Ward>> GetWards(int DistrictId);
       Task<IEnumerable<Gate>> GetGates();
    }
}

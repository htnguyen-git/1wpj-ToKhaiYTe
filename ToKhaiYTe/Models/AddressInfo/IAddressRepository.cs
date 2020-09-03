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
        /// <summary>
        /// 1: country, 2: province, 3:district, 4: ward
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        string GetNameById(string id, int sortOrder);
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models.AddressInfo
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AppDbContext context;

        public AddressRepository( AppDbContext Context)
        {
            context = Context;
        }

        public async Task<IEnumerable<Country>> GetCountry()
        {
            return await context.Country.ToListAsync();
            
        }

        public async Task<IEnumerable<District>> GetDistricts(int ProvinceId)
        {
            return await context.District.Where(e => e.ProvinceId == ProvinceId).ToListAsync();
        }

        public async Task<IEnumerable<Gate>> GetGates()
        {
            return await context.Gate.ToListAsync();
            
        }

        public async Task<IEnumerable<Province>> GetProvince()
        {
            return await context.Province.ToListAsync();
        }

        public async Task<IEnumerable<Ward>> GetWards(int DistrictId)
        {
            return await context.Ward.Where(w => w.DistrictID == DistrictId).ToListAsync();
        }
    }
}

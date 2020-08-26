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

        public Task<IEnumerable<District>> GetDistricts(int ProvinceId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Gate>> GetGates()
        {
            return await context.Gate.ToListAsync();
            
        }

        public async Task<IEnumerable<Province>> GetProvince()
        {
            return await context.Province.ToListAsync();
        }

        public Task<IEnumerable<Ward>> GetWards(int DistrictId)
        {
            throw new NotImplementedException();
        }
    }
}

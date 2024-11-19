using LibeyTechnicalTestDomain.EFCore;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Infrastructure
{
    public class UbigeoRepository: IUbigeoRepository
    {
        private readonly Context _context;
        public UbigeoRepository(Context context)
        {
            _context = context;
        }

        public List<UbigeoResponses> UbigeoFindAllResponse(string provinceCode)
        {
            var q = from ubigeoResponses in _context.Ubigeos.Where(x => x.ProvinceCode.Equals(provinceCode))
                    select new UbigeoResponses()
                    {
                        ProvinceCode = ubigeoResponses.ProvinceCode,
                        RegionCode = ubigeoResponses.RegionCode,
                        UbigeoCode = ubigeoResponses.UbigeoCode,
                        UbigeoDescription = ubigeoResponses.UbigeoDescription,
                    };
            var list = q.ToList();
            return list;
        }

        public List<ProvinceResponses> ProvinceFindAllResponse(string RegionCode)
        {
            var q = from provinceResponses in _context.Provinces.Where(x => x.RegionCode.Equals(RegionCode))
                    select new ProvinceResponses()
                    {
                        ProvinceCode = provinceResponses.ProvinceCode,
                        ProvinceDescription = provinceResponses.ProvinceDescription,
                        RegionCode = provinceResponses.RegionCode,
                    };
            var list = q.ToList();
            return list;
        }

        public List<RegionResponses> RegionFindAllResponse()
        {
            var q = from regionResponses in _context.Regions
                    select new RegionResponses()
                    {
                        RegionCode = regionResponses.RegionCode,
                        RegionDescription = regionResponses.RegionDescription
                    };
            var list = q.ToList();
            return list;
        }
    }
}

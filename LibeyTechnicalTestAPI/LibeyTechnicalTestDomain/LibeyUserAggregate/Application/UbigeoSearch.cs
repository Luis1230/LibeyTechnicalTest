using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class UbigeoSearch: IUbigeoSearch
    {
        private readonly IUbigeoRepository _repository;
        public UbigeoSearch(IUbigeoRepository repository)
        {
            _repository = repository;
        }
        public List<UbigeoResponses> UbigeoFindAllResponse(string provinceCode)
        {
            var row = _repository.UbigeoFindAllResponse(provinceCode);
            return row;
        }
        public List<ProvinceResponses> ProvinceFindAllResponse(string RegionCode)
        {
            var row = _repository.ProvinceFindAllResponse(RegionCode);
            return row;
        }
        public List<RegionResponses> RegionFindAllResponse()
        {
            var row = _repository.RegionFindAllResponse();
            return row;
        }
    }
}

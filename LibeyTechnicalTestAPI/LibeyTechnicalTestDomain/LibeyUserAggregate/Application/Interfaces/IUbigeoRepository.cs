using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface IUbigeoRepository
    {
        List<UbigeoResponses> UbigeoFindAllResponse(string provinceCode);
        List<ProvinceResponses> ProvinceFindAllResponse(string RegionCode);
        List<RegionResponses> RegionFindAllResponse();

    }
}

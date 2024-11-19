using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class DocumentTypeSearch: IDocumentTypeSearch
    {
        private readonly IDocumentTypeRepository _repository;
        public DocumentTypeSearch(IDocumentTypeRepository repository)
        {
            _repository = repository;
        }
        public List<DocumentTypeResponses> FindAllResponse()
        {
            var row = _repository.FindAllResponse();
            return row;
        }
    }
}

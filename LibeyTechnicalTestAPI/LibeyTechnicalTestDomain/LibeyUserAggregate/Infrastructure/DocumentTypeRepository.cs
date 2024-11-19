using LibeyTechnicalTestDomain.EFCore;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Infrastructure
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly Context _context;
        public DocumentTypeRepository(Context context)
        {
            _context = context;
        }
        public List<DocumentTypeResponses> FindAllResponse()
        {
            var q = from documentsType in _context.DocumentsType
                    select new DocumentTypeResponses()
                    {
                        DocumentTypeDescription = documentsType.DocumentTypeDescription,
                        DocumentTypeId = documentsType.DocumentTypeId.ToString(),
                    };
            var list = q.ToList();
            return list;
        }
    }
}

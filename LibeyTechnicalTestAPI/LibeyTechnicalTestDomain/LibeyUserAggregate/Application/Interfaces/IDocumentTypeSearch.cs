﻿using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface IDocumentTypeSearch
    {
        List<DocumentTypeResponses> FindAllResponse();
    }
}

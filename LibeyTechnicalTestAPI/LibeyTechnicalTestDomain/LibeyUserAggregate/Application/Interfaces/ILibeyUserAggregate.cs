﻿using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface ILibeyUserAggregate
    {
        List<LibeyUserResponse> FindResponse(string documentNumber);
        void Create(UserUpdateorCreateCommand command);
    }
}
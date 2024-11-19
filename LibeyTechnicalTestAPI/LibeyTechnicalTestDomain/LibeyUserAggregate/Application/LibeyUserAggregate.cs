using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;
namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class LibeyUserAggregate : ILibeyUserAggregate
    {
        private readonly ILibeyUserRepository _repository;
        public LibeyUserAggregate(ILibeyUserRepository repository)
        {
            _repository = repository;
        }
        public void Create(UserUpdateorCreateCommand command)
        {
            LibeyUser libeyUser = new LibeyUser();
            libeyUser.DocumentNumber = command.DocumentNumber;
            libeyUser.DocumentTypeId = command.DocumentTypeId;
            libeyUser.Name = command.Name;
            libeyUser.FathersLastName = command.FathersLastName;
            libeyUser.MothersLastName = command.MothersLastName;
            libeyUser.Address = command.Address;
            libeyUser.UbigeoCode = command.UbigeoCode;
            libeyUser.Phone = command.Phone;
            libeyUser.Email = command.Email;
            libeyUser.Password = command.Password;
            libeyUser.Active = true;

            _repository.Create(libeyUser);
        }
        public List<LibeyUserResponse> FindResponse(string documentNumber)
        {
            if (documentNumber == "0")
            {
                var row = _repository.FindAllResponse();
                return row;
            }
            else
            {
                var row = _repository.FindResponse(documentNumber);
                return row;
            }
        }
    }
}
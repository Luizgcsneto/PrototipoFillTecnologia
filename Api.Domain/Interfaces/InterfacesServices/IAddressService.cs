using Api.Entities.Entities;

namespace Api.Domain.Interfaces.InterfacesServices
{
    public interface IAddressService
    {
        Task AddAddress(AddressEntity address);
        Task UpdateAddress(AddressEntity address);
    }
}

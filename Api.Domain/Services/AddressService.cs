using Api.Domain.Interfaces;
using Api.Domain.Interfaces.InterfacesServices;
using Api.Entities.Entities;

namespace Api.Domain.Services
{
    public class AddressService : IAddressService
    {
        private readonly InterfaceAddress _interfaceAddress;
        public AddressService(InterfaceAddress interfaceAddress)
        {
            _interfaceAddress = interfaceAddress;
        }


        public async Task AddAddress(AddressEntity address)
        {
            await _interfaceAddress.Add(address);
        }

        public async Task UpdateAddress(AddressEntity address)
        {
            await _interfaceAddress.Update(address);
        }
    }
}

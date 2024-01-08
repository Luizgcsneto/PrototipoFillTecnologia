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
            address.CreateAt = DateTime.Now;
            await _interfaceAddress.Add(address);
        }

        public async Task<AddressEntity> GetAddressById(int id)
        {
            var result = await _interfaceAddress.GetEntityById(id);
            return result;
        }

        public async Task<List<AddressEntity>> List()
        {
            return await _interfaceAddress.List();
        }

        public async Task UpdateAddress(AddressEntity address)
        {
            address.UpdateAt = DateTime.Now;
            await _interfaceAddress.Update(address);
        }
    }
}

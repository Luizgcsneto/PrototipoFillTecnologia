using Api.Domain.Interfaces;
using Api.Domain.Interfaces.InterfacesServices;
using Api.Entities.Entities;

namespace Api.Domain.Services
{
    public class ImobileService : IimobileService
    {
        private readonly InterfaceImobile _interfaceImobile;
        public ImobileService(InterfaceImobile interfaceImobile)
        {
            _interfaceImobile = interfaceImobile;
        }
        public async Task AddImobile(ImobileEntity imobile)
        {
            imobile.CreateAt = DateTime.UtcNow;
            await _interfaceImobile.Add(imobile);
        }

        public async Task UpdateImobile(ImobileEntity imobile)
        {
            imobile.UpdateAt = DateTime.UtcNow;
            await _interfaceImobile.Update(imobile);
        }
    }
}

using Api.Domain.Interfaces;
using Api.Domain.Interfaces.InterfacesServices;
using Api.Entities.Entities;
using System.Net;

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
            imobile.CreateAt = DateTime.Now;
            await _interfaceImobile.Add(imobile);
        }

        public async Task UpdateImobile(ImobileEntity imobile)
        {
            imobile.UpdateAt = DateTime.Now;
            await _interfaceImobile.Update(imobile);
        }

        public async Task<ImobileEntity> GetImobileById(int id)
        {
            var result = await _interfaceImobile.GetEntityById(id);
            return result;
        }

        public async Task<List<ImobileEntity>> List()
        {
            return await _interfaceImobile.List();  
        }

     
    }
}

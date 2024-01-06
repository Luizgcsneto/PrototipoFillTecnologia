using Api.Entities.Entities;

namespace Api.Domain.Interfaces.InterfacesServices
{
    public interface IimobileService
    {
        Task AddImobile(ImobileEntity entity);
        Task UpdateImobile(ImobileEntity entity);
    }
}

using Api.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.InterfacesServices
{
    public interface IimobileService
    {
        Task<ImobileEntity> AddImobile(ImobileEntity entity);
        Task<ImobileEntity> UpdateImobile(ImobileEntity entity);
    }
}

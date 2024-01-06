using Api.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.InterfacesServices
{
    public interface IAddressService
    {
        Task<AddressEntity> AddAddress(AddressEntity address);
        Task<AddressEntity> UpdateAddress(AddressEntity address);
    }
}

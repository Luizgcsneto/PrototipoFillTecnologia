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
        Task AddAddress(AddressEntity address);
        Task UpdateAddress(AddressEntity address);
    }
}

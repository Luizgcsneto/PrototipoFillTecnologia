using Api.Domain.Interfaces;
using Infra.Repositories.Generics;
using Api.Entities.Entities;

namespace Infra.Repositories.Address
{
    public class RepositoryAddress : RepositoryGeneric<AddressEntity>, InterfaceAddress
    {
        public RepositoryAddress()
        {
            
        }
      

    
    }
}

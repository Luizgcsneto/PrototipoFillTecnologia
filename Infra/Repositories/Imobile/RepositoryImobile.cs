using Api.Domain.Interfaces;
using Api.Entities.Entities;
using Infra.Repositories.Generics;

namespace Infra.Repositories.Imobile
{
    public class RepositoryImobile : RepositoryGeneric<ImobileEntity>, InterfaceImobile
    {
        public RepositoryImobile()
        {
            
        }
   
    }
}

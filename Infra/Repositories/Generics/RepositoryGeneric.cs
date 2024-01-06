using Api.Domain.Interfaces;
using Infra.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories.Generics
{
    public class RepositoryGeneric<T> : InterfaceGeneric<T> where T : class
    {
        private readonly DbContextOptions<ContextBase> _optionsBuilder;
        public RepositoryGeneric()
        {
            _optionsBuilder = new DbContextOptions<ContextBase>();
        }
        public async Task Add(T objeto)
        {
            using(var data = new ContextBase(_optionsBuilder))
            {
                await data.Set<T>().AddAsync(objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task Delete(T objeto)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                data.Set<T>().Remove(objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task<T> GetEntityById(int id)
        {
            using(var data = new ContextBase(_optionsBuilder))
            {
                return await data.Set<T>().FindAsync(id);
            }
        }

        public async Task<List<T>> List()
        {
            using(var data = new ContextBase(_optionsBuilder))
            {
                return await data.Set<T>().ToListAsync();
            }
        }

        public async Task Update(T objeto)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                data.Set<T>().Update(objeto);
                await data.SaveChangesAsync();
            }
        }
    }
}

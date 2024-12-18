
namespace PerfumeriaServices.Interfaces
{
    public interface IGenericService<P> where P : class
    {
        public Task<List<P>?> GetAllAsync();
        public Task<List<P>?> GetAllDeletedAsync();
        public Task<P?> GetByIdAsync(int id);
        public Task<P?> AddAsync(P? entity);
        public Task UpdateAsync(P? entity);
        public Task DeleteAsync(int id);
    }
}

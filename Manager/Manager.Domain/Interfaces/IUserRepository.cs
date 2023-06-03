using Manager.Domain.Entities;

namespace Manager.Infra.Interfaces 
{
    public interface IUserRepository : IBaseRepository<User> 
    {
        Task<User> GetByEmail(string email);

        Task<User> SearchByEmail(string email);
        
        Task<User> SearchByName(string name);
    }
}
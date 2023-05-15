using Manager.Domain.Entities;
using Manager.Infra.Context;
using Manager.Infra.Interfaces;

namespace Manager.Infra.Repositories 
{
    public class UserRepository : BaseRepository<User>, IUserRepository 
    {
        private readonly ManagerContext _context;

        public UserRepository(ManagerContext context) : base(context) 
        {
            _context = context;
        }
        public async Task<User> GetByEmail(string email)
        {
            var user = await _context.User
            .Where{
                x => x.email.ToLower() == email.ToLower()
            }
            .AsNoTracking()
            .ToListAsync();

            return user.FirstOrDefault()
        }

        public async Task<List<User>> SearchByEmail (string email)
        {
            var allUsers = await _conttext.Users
            .Where
            {
                x => x.email.ToLower().Contains(email.ToLower())
            }
            .AutoTracking()
            .ToListAsync();

            return allUsers;
        }

        public async Task<List<User>> SearchByName(string name){
            var allUsers = wait _context.Users
            .Where
            {
                x => x.Name.ToLower().Contains(name.ToLower())
            }
            .AsNoTracking()
            .ToListAsync();

            return allUsers;
        }
    }
}
using TaskList.Data;
using TaskList.Interfaces;
using TaskList.Models;

namespace TaskList.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly DataContext _context;

        public UsersRepository(DataContext context)        
        {
            _context = context;                
        }

        public ICollection<Users> GetUsers()
        {
            return _context.User.OrderBy(p => p.IdUser).ToList();      
        }

        public Users GetUserById(int id)
        {
            return _context.User.Where(p => p.IdUser == id).FirstOrDefault()!; 
        }

        public Users GetUserByLastname(string lastName)
        {
            return _context.User.Where(u => u.LastName == lastName).FirstOrDefault()!;
        }
    }
}

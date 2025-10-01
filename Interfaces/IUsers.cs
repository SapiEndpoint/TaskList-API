using TaskList.Models;

namespace TaskList.Interfaces
{
    public interface IUsersRepository
    {
        IEnumerable<Users> GetUsers();
        Users GetUserById(int id);
        Users GetUserByLastname(string lastName);   
        bool GetUserExist(int id); 
    }
}

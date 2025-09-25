using TaskList.Models;

namespace TaskList.Interfaces
{
    public interface IUsersRepository       
    {
        ICollection<Users> GetUsers();      
        Users GetUserById(int id);              
        Users GetUserByLastname(string lastName);    
    }
}

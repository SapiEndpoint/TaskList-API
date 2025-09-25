using Microsoft.AspNetCore.Mvc;
using TaskList.Interfaces;


namespace TaskList.Controllers
{
    [Route("api/users")]     
    [ApiController]                

    public class UsersController : Controller
    {
        private readonly IUsersRepository _usrRepository;       

        public UsersController(IUsersRepository usersRepository)        
        {
            _usrRepository = usersRepository;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _usrRepository.GetUsers();

            return Ok(users);
        }

        [HttpGet("{id}")]       
        public IActionResult GetUserById(int id)
        {
            var user = _usrRepository.GetUserById(id);

            return Ok(user);
        }

        [HttpGet("lastname/{lastname}")]
        public IActionResult GetUserByLastname(string lastname)
        {
            var user = _usrRepository.GetUserByLastname(lastname);
            return Ok(user);
        }   
    }
}

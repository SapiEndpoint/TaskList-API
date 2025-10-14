using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskList.Interfaces;
using TaskList.Dto;
using TaskList.Models;

namespace TaskList.Controllers
{
    [Route("user")]
    [ApiController]

    public class UsersController : Controller
    {
        private readonly IUsersRepository _usrRepository;
        private readonly IMapper _mapper;

        public UsersController(IUsersRepository usersRepository, IMapper mapper)
        {
            _usrRepository = usersRepository;
            _mapper = mapper;
        }

        [HttpGet("/users")]
        public IActionResult GetUsers()
        {
            var users = _mapper.Map<List<User>>(_usrRepository.GetUsers());

            if (!users.Any())
                return Ok(new { message = "Utenti non trovati.", data = users });

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _mapper.Map<User>(_usrRepository.GetUserById(id));

            if (user == null)
                return NotFound(new { message = $"L'id utente {id} non trovato" });


            return Ok(user);
        }

        [HttpGet("lastname/{lastname}")]
        public IActionResult GetUserByLastname(string lastname)
        {
            var user = _mapper.Map<User>(_usrRepository.GetUserByLastname(lastname));

            if (user == null)
                return NotFound(new { message = $"Il cognome utente {lastname} non e' trovato" });
            
            return Ok(user);
        }

        [HttpGet("exist/{id}")]
        public IActionResult GetUserExist(int id)
        {
            bool exist = _usrRepository.GetUserExist(id);

            return Ok(exist);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] AddUserDTO userDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = _mapper.Map<Users>(userDTO);

            return CreatedAtAction(
                nameof(GetUserById),
                new { id = user.IdUser },
                user
            );
        }
    }
}
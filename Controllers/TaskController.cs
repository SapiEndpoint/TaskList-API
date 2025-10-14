using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskList.Dto;
using TaskList.Interfaces;
using TaskList.Models;

namespace TaskList.Controllers
{
    [Route("task")]
    [ApiController]

    public class TaskController : Controller
    {
        private readonly ITask _taskRepository;
        private readonly IMapper _mapper;

        public TaskController(ITask Task, IMapper mapper)
        {
            _taskRepository = Task;
            _mapper = mapper;
        }

        [HttpGet("/tasks")]
        public IActionResult GetTasks()
        {
            var tasks = _mapper.Map<List<TaskNoId>>(_taskRepository.GetTasks());

            if (!tasks.Any())
                return Ok(new { message = "Task non trovate.", data = tasks });

            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public IActionResult GetTaskByTaskId(int id)
        {
            var task = _mapper.Map<TaskNoId>(_taskRepository.GetTaskById(id));

            if (task == null)
                return NotFound(new { message = $"Task con l'id {id} non trovata." });

            return Ok(task);
        }

        [HttpGet("exist/{id}")]
        public IActionResult GetTaskExist(int id)
        {
            bool exist = _taskRepository.GetTaskExist(id);
            return Ok(exist);
        }

        [HttpGet("task/{userId}")]
        public IActionResult GetTaskByUserId(int userId)
        {
            var tasks = _taskRepository.GetTaskByUserId(userId);

            if (tasks == null)
                return NotFound(new { message = $"L'utente {userId} non esiste." });
            else if (!tasks.Any())
                return Ok(new { message = $"L'utente {userId} non ha task.", data = tasks });

            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult AddTask([FromBody] AddTaskDTO taskDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var task = _mapper.Map<TaskManagement>(taskDTO);

            _taskRepository.AddTask(task);

            return CreatedAtAction(
                nameof(GetTasks),
                new { id = task.IdTask },
                task
            );
        }
    }
}
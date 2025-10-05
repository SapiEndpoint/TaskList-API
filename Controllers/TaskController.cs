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

        [HttpGet]
        public IActionResult GetTasks()
        {
            var task = _mapper.Map<List<TaskNoId>>(_taskRepository.GetTasks());
            return Ok(task);
        }

        [HttpGet("{id}")]
        public IActionResult GetTaskByTaskId(int id)
        {
            var task = _mapper.Map<TaskNoId>(_taskRepository.GetTaskByTaskId(id));
            if (task == null)
            {
                return NotFound($"Task con l'id {id} non trovata.");
            }
            return Ok(task);
        }

        [HttpGet("exist/{id}")]
        public IActionResult GetTaskExist(int id)
        {
            bool exist = _taskRepository.GetTaskExist(id);
            return Ok(exist);
        }

        [HttpPost]
        public IActionResult AddTask([FromBody] AddTaskDTO taskDTO)
        {
            var task = _mapper.Map<TaskManagement>(taskDTO);
            return Ok(task);
        }
    }
}

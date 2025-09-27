using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskList.Dto;
using TaskList.Interfaces;


namespace TaskList.Controllers 
{
    [Route("api/task")]
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
            var tasks = _mapper.Map<TaskNoId>(_taskRepository.GetTaskByTaskId(id));
            return Ok(tasks);
        }
    }

}

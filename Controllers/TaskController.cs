using Microsoft.AspNetCore.Mvc;
using TaskList.Interfaces;


namespace TaskList.Controllers 
{
    [Route("api/task")]
    [ApiController]

    public class TaskController : Controller
    {
        private readonly ITask _taskRepository;

        public TaskController (ITask Task)
        {
            _taskRepository = Task;
        }

        [HttpGet]
        public IActionResult GetTasks()           
        {
            var task = _taskRepository.GetTasks();
            return Ok(task);
        }

        [HttpGet("{id}")]
        public IActionResult GetTaskByTaskId(int id)
        {
            var tasks = _taskRepository.GetTaskByTaskId(id);
            return Ok(tasks);
        }
    }

}

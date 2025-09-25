using TaskList.Models;

namespace TaskList.Interfaces
{
    public interface ITask
    {
        ICollection<TaskManagement> GetTasks(); 
        TaskManagement GetTaskByTaskId(int id); 
    }
}

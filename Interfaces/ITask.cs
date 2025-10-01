using TaskList.Models;

namespace TaskList.Interfaces
{
    public interface ITask
    {
        IEnumerable<TaskManagement> GetTasks();
        TaskManagement GetTaskByTaskId(int id); 
        bool GetTaskExist(int id);
    }
}

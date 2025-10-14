using TaskList.Models;

namespace TaskList.Interfaces
{
    public interface ITask
    {
        IEnumerable<TaskManagement> GetTasks();
        TaskManagement GetTaskById(int id);
        bool GetTaskExist(int id);
        public IEnumerable<TaskManagement> GetTaskByUserId(int userId);
        bool AddTask(TaskManagement task);
    }
}

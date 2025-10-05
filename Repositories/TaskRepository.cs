using TaskList.Data;
using TaskList.Interfaces;
using TaskList.Models;

namespace TaskList.Repositories
{
    public class TaskRepository : ITask
    {
        private readonly DataContext _context;

        public TaskRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<TaskManagement> GetTasks()
        {
            return _context.TaskManagements.OrderBy(t => t.IdTask).ToList();
        }

        public TaskManagement GetTaskByTaskId(int id)
        {
            return _context.TaskManagements.Where(t => t.IdTask == id).FirstOrDefault()!;
        }

        public bool GetTaskExist(int id)
        {
            return _context.TaskManagements.Any(t => t.IdTask == id);
        }

        public IEnumerable<TaskManagement> GetTaskByUserId(int userId)
        {
            return _context.TaskManagements.Where(u => u.IdUser == userId).ToList();
        }

        public bool AddTask(TaskManagement task)
        {
            _context.Add(task);
            return _context.SaveChanges() > 0;
        }
    }
}

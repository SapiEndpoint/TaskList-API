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

        public ICollection<TaskManagement> GetTasks()           
        {
            return _context.TaskManagements.OrderBy(t => t.IdTask).ToList();
        }

        public TaskManagement GetTaskByTaskId(int id)           
        {
            return _context.TaskManagements.Where(t => t.IdTask == id).FirstOrDefault()!;
        }
    }
}

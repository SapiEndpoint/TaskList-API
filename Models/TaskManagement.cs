namespace TaskList.Models
{
    public class TaskManagement
    {
        public int IdTask { get; set; }
        public int IdUser { get; set; }
        public string? Task { get; set; }
        public bool TaskStatus { get; set; }

        public Users? User { get; set; }  
    }
}

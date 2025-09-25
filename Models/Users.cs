namespace TaskList.Models
{
    public class Users
    {
        public int IdUser { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public ICollection<TaskManagement>? Task { get; set; }
    }
}

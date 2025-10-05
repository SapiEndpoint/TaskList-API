using System.ComponentModel.DataAnnotations;

namespace TaskList.Dto
{
    public class TaskNoId
    {
        public int IdUser { get; set; }
        public string? Task { get; set; }
        public bool TaskStatus { get; set; }
    }

    public class AddTaskDTO
    {
        [Required(ErrorMessage = "L'id utente e' obbligatorio.")]
        public int IdUser { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "La task non puo' superare i 255 caratteri.")]
        [RegularExpression(@"^[A-Z][a-z0-9]*(\s[A-Za-z0-9]+)*$", ErrorMessage = "La task deve contenere solo lettere (la prima maiuscola) e numeri.")]
        public string? Task { get; set; }

        [Required(ErrorMessage = "Lo stato e' obbligatorio.")]
        public bool TaskStatus { get; set; }
    }
}
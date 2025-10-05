using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskList.Models
{
    public class TaskManagement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTask { get; set; }

        [Required(ErrorMessage = "L'id utente e' obbligatorio.")]
        public int IdUser { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "La task non puo' superare i 255 caratteri.")]
        [RegularExpression(@"^[A-Z][a-z0-9]*(\s[A-Za-z0-9]+)*$", ErrorMessage = "La task deve contenere solo lettere (la prima maiuscola) e numeri.")]
        public string? Task { get; set; }

        [Required(ErrorMessage = "Lo stato e' obbligatorio.")]
        public bool TaskStatus { get; set; }

        [ForeignKey("IdUser")]
        public Users? User { get; set; }
    }
}

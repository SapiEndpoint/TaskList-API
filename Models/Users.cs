using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskList.Models
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUser { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "Il nome non puo' superare i 255 caratteri.")]
        [RegularExpression(@"^[A-Z][a-z]+", ErrorMessage = "Il nome deve contenere solo lettere (la prima maiuscola).")]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "Il cognome non puo' superare i 255 caratteri.")]
        [RegularExpression(@"^[A-Z][a-z]+", ErrorMessage = "Il cognome deve contenere solo lettere (la prima maiuscola).")]
        public string? LastName { get; set; }

        public ICollection<TaskManagement>? Task { get; set; }
    }
}

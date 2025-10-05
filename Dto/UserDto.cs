using System.ComponentModel.DataAnnotations;

namespace TaskList.Dto
{
    public class User
    {
        public int IdUser { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

    public class AddUserDTO
    {
        [Required]
        [MaxLength(255, ErrorMessage = "Il nome non puo' superare i 255 caratteri.")]
        [RegularExpression(@"^[A-Z][a-z]+", ErrorMessage = "Il nome deve contenere solo lettere (la prima maiuscola).")]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "Il cognome non puo' superare i 255 caratteri.")]
        [RegularExpression(@"^[A-Z][a-z]+", ErrorMessage = "Il cognome deve contenere solo lettere (la prima maiuscola).")]
        public string? LastName { get; set; }
    }
}
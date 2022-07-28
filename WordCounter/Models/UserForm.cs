using System.ComponentModel.DataAnnotations;

namespace WordCounter.Models
{
    public class UserForm
    {
        [Required(ErrorMessage = "Some text input is required.")]
        public string? InsertedText { get; set; }
    }
}

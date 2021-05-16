using System.ComponentModel.DataAnnotations;

namespace YurgiOne.ViewModels
{
    public class ContactViewModel
    {
        [Required] [MinLength(2)] public string Name { get; set; }

        [Required] public string Email { get; set; }

        [Required] [MaxLength(10)] public string Message { get; set; }

        [Required] public string Subject { get; set; }
    }
}
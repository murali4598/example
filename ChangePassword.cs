using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class ChangePassword
    {
        [Required]
        public string CurrentPassword { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace HelpingHandsWebApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string ContactNumber { get; set; }
        public string UserType { get; set; }
        public string UserStatus { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace HelpingHandsWebApp.Models
{
    public class CompanyInformation
    {
        [Key]
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string NPO_Number { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string Email { get; set; }
        public TimeOnly OperationalHours { get; set; }
       
    }
}

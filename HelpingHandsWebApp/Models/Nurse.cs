using System.ComponentModel.DataAnnotations;

namespace HelpingHandsWebApp.Models
{
    public class Nurse
    {
        [Key]
        public int NurseId { get; set; }

        public string? NurseCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string IDNumber { get; set; }
        public string DOB { get; set; }

        public string SuburbID { get; set; }
        public string UserID { get; set; }
    }
}

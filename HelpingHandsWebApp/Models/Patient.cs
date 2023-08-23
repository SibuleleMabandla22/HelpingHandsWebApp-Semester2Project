using System.ComponentModel.DataAnnotations;

namespace HelpingHandsWebApp.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string IDNumber { get; set; }
        public string DOB { get; set; }
        public string ChronicCondition { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNo { get; set; }
        public string AdditionalInfo { get; set; }

        public string SuburbID { get; set; }
        public string UserID { get; set; }
    }
}

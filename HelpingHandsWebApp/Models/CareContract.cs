using System.ComponentModel.DataAnnotations;

namespace HelpingHandsWebApp.Models
{
    public class CareContract
    {
        [Key]
        public int ContractId { get; set; }

        public int ContractNo { get; set; }
        public DateTime ContractDate { get; set; }
        public int PatientId { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string Suburb { get; set; }
        public string WoundDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? NurseId { get; set; }
        public string ContractStatus { get; set; }
    }
}

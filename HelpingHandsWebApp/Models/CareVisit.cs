using System.ComponentModel.DataAnnotations;

namespace HelpingHandsWebApp.Models
{
    public class CareVisit
    {
        [Key]
        public int VisitId { get; set; }

        public int ContractId { get; set; }

        public DateTime VisitDate { get; set; }
        //public TimeSpan ApproximateArriveTime { get; set; }
        public TimeSpan ArriveTime { get; set; }
        public TimeSpan DepartTime { get; set; }
        public string WoundCondition { get; set;}
        public string Notes { get; set;}
    }
}

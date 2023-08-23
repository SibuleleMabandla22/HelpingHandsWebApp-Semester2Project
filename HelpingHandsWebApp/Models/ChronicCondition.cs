using System.ComponentModel.DataAnnotations;

namespace HelpingHandsWebApp.Models
{
    public class ChronicCondition
    {
        [Key]
        public int ConditionId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}

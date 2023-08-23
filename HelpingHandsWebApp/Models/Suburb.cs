using System.ComponentModel.DataAnnotations;

namespace HelpingHandsWebApp.Models
{
    public class Suburb
    {
        [Key]
        public int SuburbId { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public int CityId { get; set; }
    }
}

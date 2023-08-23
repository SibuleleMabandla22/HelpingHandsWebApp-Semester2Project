using System.ComponentModel.DataAnnotations;

namespace HelpingHandsWebApp.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        public string Abbreviation { get; set; }
        public string Name { get; set; }
        
    }
}

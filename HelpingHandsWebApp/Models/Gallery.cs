using System.ComponentModel.DataAnnotations;

namespace HelpingHandsWebApp.Models
{
    public class Gallery
    {
        [Key]
        public int GalleryId { get; set; }
        public byte[] Photo { get; set; }
        public int CompanyId { get; set; }
    }
}

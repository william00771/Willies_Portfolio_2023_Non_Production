using System.ComponentModel.DataAnnotations;

namespace Willies_Portfolio_2023.Models
{
    public class Still
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [Required]
        public string ImagePreview { get; set; }
        [Required]
        public string ImageHighQuality { get; set; }
        public string? ImageMediumQuality { get; set; }
        public string? ImageLowQuality { get; set; }
    }
}

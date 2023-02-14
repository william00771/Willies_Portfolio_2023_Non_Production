using System.ComponentModel.DataAnnotations;

namespace Willies_Portfolio_2023.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Title { get; set; }
        public string ?Description { get; set; }
        [Required]
        public string FilmPreview { get; set; }
        [Required]
        public string FilmMain { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace Willies_Portfolio_2023.Models
{
    public class NetProjectBreakdownSection
    {
        [Key]
        public int Id { get; set; }
        public string Header { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string DescriptionHeader { get; set; }
        [Required]
        public string BreakdownImage { get; set; }
        public string? BreakdownSecondaryImage { get; set; }

        [Required]
        public ICollection<NetProjectDescription> NetProjectDescriptions { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Willies_Portfolio_2023.Models
{
    public class NetProject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string DescriptionHeader { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TitleImage { get; set; }

        public ICollection<NetProjectBreakdownSection> NetProjectBreakdownSections { get; set; }

    }
}

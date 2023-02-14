using System.ComponentModel.DataAnnotations;

namespace Willies_Portfolio_2023.Models
{
    public class NetProjectDescription
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public NetProjectBreakdownSection NetProjectBreakdownSection { get; set; }
    }
}

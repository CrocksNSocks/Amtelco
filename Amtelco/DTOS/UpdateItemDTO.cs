using System.ComponentModel.DataAnnotations;

namespace Amtelco.DTOS
{
    public record UpdateItemDTO
    {
        [Required]
        public int Created { get; set; }
        [Required]
        public int LastChanged { get; set; }
        [Required]
        [Range(8, 21)]
        public int Start { get; set; }
        [Required]
        [Range(1, 2)]
        public int Duration { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public bool IsComplete { get; set; }
    }
}

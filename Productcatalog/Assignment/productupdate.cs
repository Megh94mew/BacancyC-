using System.ComponentModel.DataAnnotations;

namespace YourProject.DTOs
{
    public class ProductUpdateDTo
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Range(1, 100000)]
        public decimal Price { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
    }
}
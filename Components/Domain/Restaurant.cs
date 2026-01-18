using System.ComponentModel.DataAnnotations;

namespace MakanGoFood.Domain
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Location { get; set; } = "";

        [Required]
        public string OpeningHours { get; set; } = "";

        public decimal Rating { get; set; }

        public string? ImageUrl { get; set; }

        [Required]
        public string Cuisine { get; set; } = "";
    }
}

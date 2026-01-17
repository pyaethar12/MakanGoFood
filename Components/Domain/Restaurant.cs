using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakanGoFood.Domain
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }   // PK

        [Required]
        public string Name { get; set; } = "";

        public string Location { get; set; } = "";

        public string OpeningHours { get; set; } = "";

        [Range(0, 5)]
        [Column(TypeName = "decimal(3,2)")]
        public decimal Rating { get; set; } = 0;
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakanGoFood.Domain
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }   // PK

        [Required]
        public string Name { get; set; } = "";

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        // FK
        public int RestaurantId { get; set; }

        // Navigation (optional but good)
        public Restaurant? Restaurant { get; set; }
    }
}

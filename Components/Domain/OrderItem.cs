using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakanGoFood.Domain
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }   // PK

        [Range(1, 999)]
        public int Quantity { get; set; } = 1;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Subtotal { get; set; } = 0;

        // FK
        public int OrderId { get; set; }
        public int MenuId { get; set; }

        // Navigation (optional)
        public Order? Order { get; set; }
        public Menu? Menu { get; set; }
    }
}

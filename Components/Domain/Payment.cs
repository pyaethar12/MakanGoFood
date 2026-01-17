using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakanGoFood.Domain
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }   // PK

        [Required]
        public string PaymentMethod { get; set; } = "Card";

        [Required]
        public string PaymentStatus { get; set; } = "Pending";

        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; } = 0;

        // FK
        public int OrderId { get; set; }

        // Navigation (optional)
        public Order? Order { get; set; }
    }
}

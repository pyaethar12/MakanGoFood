using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakanGoFood.Domain
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public string PaymentMethod { get; set; } = "Card";

        [Required]
        public string PaymentStatus { get; set; } = "Pending";

        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; } = 0;

        // ✅ ADD THESE
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? PaidAt { get; set; }
        public string? TransactionRef { get; set; }

        // FK
        public int OrderId { get; set; }

        public Order? Order { get; set; }
    }
}

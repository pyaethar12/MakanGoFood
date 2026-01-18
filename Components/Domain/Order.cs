using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakanGoFood.Domain
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDateTime { get; set; } = DateTime.Now;

        [Required]
        public string OrderStatus { get; set; } = "Pending";

        // ✅ ADD THIS
        [Column(TypeName = "decimal(10,2)")]
        public decimal OrderTotal { get; set; } = 0;

        // FK
        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        public int? RiderId { get; set; }
        public int RestaurantId { get; set; }

        // Navigation
        public Address? Address { get; set; }
        public Customer? Customer { get; set; }
        public DeliveryRider? Rider { get; set; }
        public Restaurant? Restaurant { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        // ✅ OPTIONAL (if you want one-to-one)
        public Payment? Payment { get; set; }
    }
}

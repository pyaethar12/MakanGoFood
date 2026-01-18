using System.ComponentModel.DataAnnotations;

namespace MakanGoFood.Domain
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }   // PK

        public DateTime OrderDateTime { get; set; } = DateTime.Now;

        [Required]
        public string OrderStatus { get; set; } = "Pending";

        // FK
        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        public int? RiderId { get; set; }
        public int RestaurantId { get; set; }

        // Navigation (optional)
        public Address? Address { get; set; }
        public Customer? Customer { get; set; }
        public DeliveryRider? Rider { get; set; }
        public Restaurant? Restaurant { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}

using System.ComponentModel.DataAnnotations;

namespace MakanGoFood.Domain
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }   // PK

        [Required]
        public string Street { get; set; } = "";

        [Required]
        public string City { get; set; } = "";

        [Required]
        public string PostalCode { get; set; } = "";

        // FK
        public int CustomerId { get; set; }

        // Navigation (optional)
        public Customer? Customer { get; set; }
    }
}

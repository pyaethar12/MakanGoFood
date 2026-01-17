using System.ComponentModel.DataAnnotations;

namespace MakanGoFood.Domain
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }   // PK

        [Required]
        public string? Name { get; set; }

        [Required, EmailAddress]
        public string? Email { get; set; } 

        public string? Phone { get; set; } 
    }
}

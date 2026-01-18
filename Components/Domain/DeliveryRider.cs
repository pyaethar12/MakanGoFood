using System.ComponentModel.DataAnnotations;

namespace MakanGoFood.Domain
{
    public class DeliveryRider
    {
        [Key]
        public int RiderId { get; set; }   // PK

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Phone { get; set; } = "";

        public string VehicleNo { get; set; } = "";

        [Required, EmailAddress]
        public string Email { get; set; } = "";
    }
}

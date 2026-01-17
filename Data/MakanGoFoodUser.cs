using Microsoft.AspNetCore.Identity;

namespace MakanGoFood.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class MakanGoFoodUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}

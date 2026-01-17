using MakanGoFood.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakanGoFood.Configurations.Entities
{
    public class RestaurantSeed : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData(
                new Restaurant
                {
                    RestaurantId = 1,
                    Name = "Golden Dragon",
                    Location = "Tampines",
                    OpeningHours = "10am - 10pm",
                    Rating = 4.50m
                },
                new Restaurant
                {
                    RestaurantId = 2,
                    Name = "Bangkok Bites",
                    Location = "Bedok",
                    OpeningHours = "11am - 9pm",
                    Rating = 4.20m
                }
            );
        }
    }
}

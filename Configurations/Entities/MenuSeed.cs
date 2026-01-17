using MakanGoFood.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakanGoFood.Configurations.Entities
{
    public class MenuSeed : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasData(
                new Menu
                {
                    MenuId = 1,
                    Name = "Chicken Rice",
                    Price = 5.50m,
                    RestaurantId = 1
                },
                new Menu
                {
                    MenuId = 2,
                    Name = "Pad Thai",
                    Price = 6.80m,
                    RestaurantId = 2
                }
            );
        }
    }
}

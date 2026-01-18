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
                // Restaurant 1: Golden Dragon (Chinese)
                new Menu { MenuId = 1, Name = "Chicken Rice", Price = 5.50m, RestaurantId = 1 },
                new Menu { MenuId = 2, Name = "Sweet & Sour Pork", Price = 7.20m, RestaurantId = 1 },
                new Menu { MenuId = 3, Name = "Wonton Noodles", Price = 6.00m, RestaurantId = 1 },

                // Restaurant 2: Bangkok Bites (Thai)
                new Menu { MenuId = 4, Name = "Pad Thai", Price = 6.80m, RestaurantId = 2 },
                new Menu { MenuId = 5, Name = "Tom Yum Soup", Price = 7.50m, RestaurantId = 2 },
                new Menu { MenuId = 6, Name = "Green Curry Chicken", Price = 8.20m, RestaurantId = 2 },

                // Restaurant 3: Yangon Delights (Burmese)
                new Menu { MenuId = 7, Name = "Mohinga", Price = 5.00m, RestaurantId = 3 },
                new Menu { MenuId = 8, Name = "Tea Leaf Salad", Price = 4.80m, RestaurantId = 3 },
                new Menu { MenuId = 9, Name = "Shan Noodles", Price = 6.20m, RestaurantId = 3 },

                // Restaurant 4: Westside Grill (Western)
                new Menu { MenuId = 10, Name = "Grilled Chicken Chop", Price = 9.90m, RestaurantId = 4 },
                new Menu { MenuId = 11, Name = "Fish & Chips", Price = 10.50m, RestaurantId = 4 },
                new Menu { MenuId = 12, Name = "Carbonara Pasta", Price = 9.50m, RestaurantId = 4 },

                // Restaurant 5: Burger Blast (Fast Food)
                new Menu { MenuId = 13, Name = "Classic Beef Burger", Price = 6.90m, RestaurantId = 5 },
                new Menu { MenuId = 14, Name = "Crispy Chicken Burger", Price = 6.50m, RestaurantId = 5 },
                new Menu { MenuId = 15, Name = "Fries + Drink Set", Price = 4.90m, RestaurantId = 5 },

                // Restaurant 6: Seoul Kitchen (Korean)
                new Menu { MenuId = 16, Name = "Kimchi Fried Rice", Price = 7.20m, RestaurantId = 6 },
                new Menu { MenuId = 17, Name = "Bibimbap", Price = 8.50m, RestaurantId = 6 },
                new Menu { MenuId = 18, Name = "Korean Fried Chicken", Price = 9.80m, RestaurantId = 6 },

                // Restaurant 7: Sakura Sushi (Japanese)
                new Menu { MenuId = 19, Name = "Salmon Sushi Set", Price = 12.50m, RestaurantId = 7 },
                new Menu { MenuId = 20, Name = "Chicken Katsu Don", Price = 9.20m, RestaurantId = 7 },
                new Menu { MenuId = 21, Name = "Ramen (Shoyu)", Price = 10.50m, RestaurantId = 7 },

                // Restaurant 8: Tea & Chill (Drinks)
                new Menu { MenuId = 22, Name = "Milk Tea (Large)", Price = 4.50m, RestaurantId = 8 },
                new Menu { MenuId = 23, Name = "Matcha Latte", Price = 5.20m, RestaurantId = 8 },
                new Menu { MenuId = 24, Name = "Brown Sugar Boba", Price = 5.80m, RestaurantId = 8 }
            );
        }
    }
}

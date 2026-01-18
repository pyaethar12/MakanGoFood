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
                    OpeningHours = "10:00 AM - 10:00 PM",
                    Rating = 4.50m,
                    ImageUrl = "/images/restaurants/golden-dragon.jpg",
                    Cuisine = "Chinese"
                },
                new Restaurant
                {
                    RestaurantId = 2,
                    Name = "Bangkok Bites",
                    Location = "Bedok",
                    OpeningHours = "11:00 AM - 9:00 PM",
                    Rating = 4.40m,
                    ImageUrl = "/images/restaurants/bangkok-bites.jpeg",
                    Cuisine = "Thai"
                },
                new Restaurant
                {
                    RestaurantId = 3,
                    Name = "Yangon Kitchen",
                    Location = "Yishun",
                    OpeningHours = "9:00 AM - 8:00 PM",
                    Rating = 4.30m,
                    ImageUrl = "/images/restaurants/yangon-delight.webp",
                    Cuisine = "Burmese"
                },
                new Restaurant
                {
                    RestaurantId = 4,
                    Name = "Steak & Grill",
                    Location = "Jurong",
                    OpeningHours = "12:00 PM - 11:00 PM",
                    Rating = 4.60m,
                    ImageUrl = "/images/restaurants/steak-grill.jpg",
                    Cuisine = "Western"
                },
                new Restaurant
                {
                    RestaurantId = 5,
                    Name = "Burger Hub",
                    Location = "Woodlands",
                    OpeningHours = "10:00 AM - 12:00 AM",
                    Rating = 4.20m,
                    ImageUrl = "/images/restaurants/burger-hub.jpg",
                    Cuisine = "Fast Food"
                },
                new Restaurant
                {
                    RestaurantId = 6,
                    Name = "Seoul BBQ",
                    Location = "City Hall",
                    OpeningHours = "11:00 AM - 10:00 PM",
                    Rating = 4.70m,
                    ImageUrl = "/images/restaurants/seoul-bbq.jpg",
                    Cuisine = "Korean"
                },
                new Restaurant
                {
                    RestaurantId = 7,
                    Name = "Sakura Sushi",
                    Location = "Bishan",
                    OpeningHours = "11:00 AM - 9:30 PM",
                    Rating = 4.60m,
                    ImageUrl = "/images/restaurants/sakura-sushi.jpg",
                    Cuisine = "Japanese"
                },
                new Restaurant
                {
                    RestaurantId = 8,
                    Name = "Tea & Chill",
                    Location = "Paya Lebar",
                    OpeningHours = "10:00 AM - 11:00 PM",
                    Rating = 4.80m,
                    ImageUrl = "/images/restaurants/tea-chill.jpeg",
                    Cuisine = "Drinks"
                }
            );
        }
    }
}

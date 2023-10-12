using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FlowerBeauty.Data;
using System;
using System.Linq;

namespace FlowerBeauty.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new FlowerBeautyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FlowerBeautyContext>>());
            //Look for any Flowers
            if (context.Flower.Any())
            {
                return;  //DB has been seeded
            }

            context.Flower.AddRange(
                new Flower
                {
                    Name = "Red Rose Bouquet",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Category = "Bouquet",
                    Description = "Roses with beautiful accents of Babies Breath and stunning lush greenery. This cut flower bouquet is ready to by placed in a vase and admired.",
                    Price = 7.99M,
                    StoreLocation = "686 Janette Ave, Windsor, ON",
                    Rating = "5"
                },

                 new Flower
                 {
                     Name = "Rainbow Crown",
                     ReleaseDate = DateTime.Parse("1989-2-12"),
                     Category = "Jewelery",
                     Description = "Check out our rainbow flower crown selection for the very best in unique or custom, handmade pieces from our wreaths & tiaras shops.",
                     Price = 5.15M,
                     StoreLocation = "558 Erie St E #1, Windsor, ON",
                     Rating = "4.5"
                 },

                  new Flower
                  {
                      Name = "The Home Box",
                      ReleaseDate = DateTime.Parse("1989-2-12"),
                      Category = "Gift Box",
                      Description = "Introducing The Home Box! Our newest Gift Box with all the Home goodies you'll need. Think of a new Homeowner, Daughter getting her own place or gift for a friend!",
                      Price = 12.05M,
                      StoreLocation = "637 Bay St., Toronto, ON",
                      Rating = "4"
                  },

                   new Flower
                   {
                       Name = "Aleo Vera",
                       ReleaseDate = DateTime.Parse("1989-2-12"),
                       Category = "Plant",
                       Description = "The Aloe vera plant is an easy, attractive succulent that makes an excellent indoor companion.",
                       Price = 9.00M,
                       StoreLocation = "558 Erie St E #1, Windsor, ON",
                       Rating = "5"

                   },

                    new Flower
                    {
                        Name = "DIY-Kit Silk Wreath",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Category = "DIY-Kit",
                        Description = "Silk Wreath DIY kits are $5.35 and are delivered right to your doorstep so you don't miss out on any creative time!",
                        Price = 5.35M,
                        StoreLocation = "686 Janette Ave, Windsor, ON",
                        Rating = "5"
                    }
                );
            context.SaveChanges();
        }
    }
}

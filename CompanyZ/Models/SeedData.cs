using CompanyZ.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyZ.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Ingredients.Any())
                {
                    return;   // DB has been seeded
                }

                context.Ingredients.AddRange(
                    new Ingredients
                    {
                        IngredientName = "Black pepper",
                        IngredientType = "Seasoning",
                        IngredientDesc = "Spicy flavour",
                        Quantity = 25,
                        Price = 7.99M,
                        ExpiryDate = DateTime.Parse("2023-2-12")
                    },

                    new Ingredients
                    {
                        IngredientName = "Salt",
                        IngredientType = "Seasoning",
                        IngredientDesc = "General usage",
                        Quantity = 10,
                        Price = 2.99M,
                        ExpiryDate = DateTime.Parse("2022-5-12")
                    },

                    new Ingredients
                    {
                        IngredientName = "Chilli flakes",
                        IngredientType = "Seasoning",
                        IngredientDesc = "Spicy flavour",
                        Quantity = 50,
                        Price = 4.99M,
                        ExpiryDate = DateTime.Parse("2026-6-24")
                    },

                    new Ingredients
                    {
                        IngredientName = "Sugar",
                        IngredientType = "Seasoning",
                        IngredientDesc = "General uses",
                        Quantity = 15,
                        Price = 3.99M,
                        ExpiryDate = DateTime.Parse("2023-5-21")
                    },

                    new Ingredients
                    {
                        IngredientName = "Chicken breast",
                        IngredientType = "Raw materials",
                        IngredientDesc = "Meat",
                        Quantity = 12,
                        Price = 12.99M,
                        ExpiryDate = DateTime.Parse("2020-1-12")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}


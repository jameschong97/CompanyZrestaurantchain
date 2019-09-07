using CompanyZ.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyZ.Models
{
    public static class SeedMealData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Meal.Any())
                {
                    return;   // DB has been seeded
                }

                context.Meal.AddRange(
                    new Meal
                    {
                        MealName = "Chicken Burger",
                        MealType = "Western",
                        MealDesc = "Burger with a slice of chicken patty",
                        Quantity = 25,
                        Price = 9.99M                      
                    },

                    new Meal
                    {
                        MealName = "Chicken Chop",
                        MealType = "Western",
                        MealDesc = "A piece of grilled chicken with sides",
                        Quantity = 42,
                        Price = 19.99M
                    },

                    new Meal
                    {
                        MealName = "Fried Rice",
                        MealType = "Chinese",
                        MealDesc = "A plate of rice that is fried",
                        Quantity = 12,
                        Price = 5.99M
                    },

                    new Meal
                    {
                        MealName = "Nasi Lemak",
                        MealType = "Local",
                        MealDesc = "Best food, recommended by chef",
                        Quantity = 36,
                        Price = 8.99M
                    },

                    new Meal
                    {
                        MealName = "Satay",
                        MealType = "Local",
                        MealDesc = "One stick with meat on it",
                        Quantity = 50,
                        Price = 1.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

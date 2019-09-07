using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CompanyZ.Models;

namespace CompanyZ.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CompanyZ.Models.Ingredients> Ingredients { get; set; }
        public DbSet<CompanyZ.Models.Meal> Meal { get; set; }
        public DbSet<CompanyZ.Models.Order> Order { get; set; }
        public DbSet<CompanyZ.Models.Feedback> Feedback { get; set; }

        
    }
}

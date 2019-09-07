using CompanyZ.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyZ.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context,
                              UserManager<ApplicationUser> userManager,
                              RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            String branchManagerId = "";
            String storeManagerId = "";

            string role1 = "BranchManager";           
            string role2 = "StoreManager";            

            string password = "Qwe123!";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1));
            }

            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2));
            }

            if (await userManager.FindByNameAsync("admin1@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                branchManagerId = user.Id;
            }

            if (await userManager.FindByNameAsync("user1@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
                storeManagerId = user.Id;
            }


        }
    }
}

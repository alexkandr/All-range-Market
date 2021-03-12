using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace All_Range_Market.Models
{

    public static class SeedUsers
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Secret123$";

        public static async void EnsurePopulated(IApplicationBuilder app)
        {

            AppIdentityDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<AppIdentityDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            UserManager<IdentityUser> userManager = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();
            RoleManager<IdentityRole> roleManager = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();

            if (await roleManager.FindByNameAsync("Admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            if (await roleManager.FindByNameAsync("Customer") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Customer"));
            }
            if(await roleManager.FindByNameAsync("Brand") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Brand"));
            }
            IdentityUser admin = await userManager.FindByNameAsync(adminUser);
            if (admin == null)
            {
                admin = new IdentityUser("Admin");
                admin.Email = "akantyevad@gmail.com";
                admin.PhoneNumber = "+7(913)-530-08-18";
                await userManager.CreateAsync(admin, adminPassword);
                await userManager.AddToRoleAsync(admin, "Admin");
            }
            
            }
        }
}

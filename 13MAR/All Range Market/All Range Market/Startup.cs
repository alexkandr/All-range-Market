using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using All_Range_Market.Models;
using Microsoft.AspNetCore.Identity;

namespace All_Range_Market
{
    public class Startup
    {

        public Startup(IConfiguration config)
        {
            Configuration = config;
        }

        private IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<StoreDbContext>(opts => 
            {
                opts.UseSqlServer(
                    Configuration["ConnectionStrings:ARMarketConnection"]);
            });
            services.AddDbContext<AppIdentityDbContext>(opts =>
            {
                opts.UseSqlServer(
                    Configuration["ConnectionStrings:IdentityConnection"]);
            });
            services.AddScoped<IProductRepository, EFProductRepository>();
            services.AddScoped<IOrderRepository, EFOrderRepository>();
            services.AddScoped<IVendorRepository, EFVendorRepository>();
            services.AddScoped<ICommentsRepository, EFCommentsRepository>();
            services.AddRazorPages();
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppIdentityDbContext>();
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddServerSideBlazor();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
            {
                app.UseHsts();
            }
            app.UseStatusCodePagesWithReExecute("/error", "?code={0}");
            app.UseCookiePolicy();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute("error", "/error{code:int}",
                    new { Controller = "Home", action = "Error" });
                endpoints.MapControllerRoute("login", "login",
                    new { Controller = "Account", action = "Login" });
                endpoints.MapControllerRoute("Reg", "Registration",
                    new { Controller = "Account", action = "Register" });
                endpoints.MapControllerRoute("catpage", "Catalog/{category}/Page{productPage:int}",
                    new { Controller = "Home", action = "Catalog" });
                endpoints.MapControllerRoute("selpage", "Brand/{brand}/Page{productPage:int}",
                    new { Controller = "Home", action = "Shop"});
                endpoints.MapControllerRoute("product", "Brand/{brand}/{productId:int}",
                    new { Controller = "Home", action = "SingleProduct" });
                endpoints.MapControllerRoute("seller", "Brand/{brand}",
                    new { Controller = "Home", action = "Shop", productPage = 1 });
                endpoints.MapControllerRoute("pagination", "Catalog/Page{productPage:int}",
                    new { Controller = "Home", action = "Catalog", productPage = 1 });
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
            });

            SeedData.EnsurePopulated(app);
            SeedUsers.EnsurePopulated(app);
        }
    }
}

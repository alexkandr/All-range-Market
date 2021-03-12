using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace All_Range_Market.Models
{

    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                var nike = new Vendor
                {
                    Brand = "Nike",
                    Description = "Nike official",
                    TrustRate = 4.0
                };
                var asics =
                    new Vendor
                    {
                        Brand = "Asics",
                        Description = "Asics official",
                        TrustRate = 5.0
                    };
                var nb = new Vendor
                {
                    Brand = "New Balance",
                    Description = "New Balance official",
                    TrustRate = 1.0
                };
                context.Vendors.AddRange
                    (nike, asics, nb);
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Nike Air VaporMax 2020 FK",
                        Description = "Мужская обувь для тренинга",
                        Category = "Кроссовки",
                        Price = 18299,
                        gender = GenderPref.Men,
                        Vendor = nike,
                        Rate = 4.5,
                        Bought = 5,
                        AvaibleSizes = new List<ProductSize>{ new ProductSize("M"), new ProductSize("S") },
                        Images = new List<Image> { new Image(@"\Images\Companies\Nike\Download(3).png"), new Image(@"\Images\Companies\Nike\Download(4).png") }
                    },
                    new Product
                    {
                        Name = "Nike Free Metcon 3",
                        Description = "Женская Обувь для тренинга",
                        Category = "Кроссовки",
                        Price = 8669,
                        gender = GenderPref.Women,
                        Vendor = nike,
                        Rate = 4.0,
                        Bought = 45,
                        AvaibleSizes = new List<ProductSize> { new ProductSize("M"), new ProductSize("S"), new ProductSize("L") },
                        Images = new List<Image> { new Image(@"\Images\Companies\Nike\Download(1).png"), new Image( @"\Images\Companies\Nike\Download.png"), new Image(@"\Images\Companies\Nike\Download(2).png") }
                    },
                    new Product
                    {
                        Name = "Футболка с длинным рукавом Q Speed Run Crew",
                        Description = "Удобный лонгслив для спорта",
                        Category = "Футболки",
                        Price = 7490,
                        gender = GenderPref.Men,
                        Vendor = nb,
                        Rate = 2.0,
                        Bought = 0,
                        AvaibleSizes = new List<ProductSize> { new ProductSize("M"), new ProductSize("S"), new ProductSize("L") },
                        Images = new List<Image> { new Image(@"\Images\Companies\NewBalance\Download(5).png") }
                    },
                    new Product
                    {
                        Name = "GEL-FLARE 7 GS",
                        Description = "Детская обувь для Волейбола",
                        Category = "Кроссовки",
                        Price = 5000,
                        gender = GenderPref.Kids,
                        Vendor = asics,
                        Rate = 4.6,
                        Bought = 20,
                        AvaibleSizes = new List<ProductSize> { new ProductSize("L") },
                        Images = new List<Image> {new Image( @"\Images\Companies\Asics\Download(2).jpg"), new Image(@"\Images\Companies\Asics\Download(3).jpg")}
                    }
                    
                );;
                context.Comments.AddRange
                (new List<Comment>
                    {
                    new Comment
                    {
                        Vendor = nike,
                        Content = "Обожаю найк и всё что с ним связано",
                        User = "NikeEnjoyer",
                        Time = DateTime.Now
                    },
                    new Comment
                    {
                        Vendor = nike,
                        Content = "Не люблю найк и всё что с ним связано",
                        User = "NikesHater",
                        Time = DateTime.Now
                    }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

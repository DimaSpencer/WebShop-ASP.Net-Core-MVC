using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using XESShop.Models;

namespace XESShop.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public override DbSet<User> Users { get; set; }
        //public DbSet<Basket> Baskets { get; set; }
        public DbSet<Identity> Identityes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Fluent API
            //builder.Entity<User>().OwnsOne(u => u.Identity, i => i.OwnsOne(i => i.Address));
            builder.Entity<Identity>().OwnsOne(i => i.Address);

            List<Category> categories = new List<Category>
            {
                new Category{ Id = 1, Name = "Электроника" },
                new Category{ Id = 2, Name = "Компьютеры и ноутбуки" },
                new Category{ Id = 3, Name = "Смартфоны" },
                new Category{ Id = 4, Name = "Товары для геймеров" }

            };

            List<Manufacturer> manufacturers = new List<Manufacturer>
            {
                new Manufacturer{ Id = 1, Name = "Apple" },
                new Manufacturer{ Id = 2, Name = "Microsoft" },
                new Manufacturer{ Id = 3, Name = "Xiaomi" },
                new Manufacturer{ Id = 4, Name = "Electronic Arts" },
                new Manufacturer{ Id = 5, Name = "Samsung" }
            };

            List<Product> products = new List<Product>
            {
                new Product{
                    Id = 1,
                    Name = "iPhone 12 Pro Max",
                    BigName = "Мобильный телефон Apple iPhone 12 256GB Purple Официальная гарантия",
                    Description = "Экран (6.7, OLED (Super Retina XDR), 2778x1284) /" +
                    "Apple A14 Bionic / тройная основная камера: 12 Мп + 12 Мп + 12 Мп," +
                    "фронтальная камера: 12 Мп / 128 ГБ встроенной памяти" +
                    "/ 3G / LTE / 5G / GPS / Nano - SIM / iOS 14",
                    CategoryId  = 3,
                    ManufacturerId = 1,
                    Price = 43999
                    //Photos = new List<Picture>
                    //{
                    //    new Picture { Id = 1, Name = "iphone", Path = "/images/products/iphone.jpg"}
                    //}
                },
                new Product{
                    Id = 2,
                    Name = "Samsung Galaxy S21 Ultra",
                    BigName = "Мобильный телефон Samsung Galaxy S21 Ultra 12/256GB Phantom Black (SM-G998BZKGSEK)",
                    Description = "Экран (6.8, Dynamic AMOLED 2X, 3200x1440)/" +
                    "Samsung Exynos 2100(1 x 2.9 ГГц + 3 x 2.8 ГГц + 4 x 2.2 ГГц) /" +
                    "основная квадро - камера: 108 Мп + 12 Мп + 10 Мп + 10 Мп, фронтальная: 40 Мп /" +
                    "RAM 12 ГБ / 256 ГБ встроенной памяти / 3G / LTE / 5G / GPS /" +
                    "поддержка 2х SIM-карт(Nano - SIM) / Android 11.0 / 5000 мА* ч",
                    CategoryId  = 3,
                    ManufacturerId = 5,
                    Price = 40000
                    //Photos = new List<Picture>
                    //{
                    //    new Picture { Id = 2, Name = "samsung", Path = "/images/products/samsung.jpg" }
                    //}
                },
                new Product{
                    Id = 3,
                    Name = "Apple MacBook Air 13",
                    BigName = "Ноутбук Apple MacBook Air 13, M1 256GB 2020 (MGN63) Space Gray",
                    Description = "Экран 13.3 Retina (2560x1600) WQXGA, глянцевый /" +
                    "Apple M1 / RAM 8 ГБ / SSD 256 ГБ / Apple M1 Graphics / Wi-Fi /" +
                    "Bluetooth / macOS Big Sur / 1.29 кг / серый",
                    CategoryId  = 3,
                    ManufacturerId = 5,
                    Price = 40000
                    //Photos = new List<Picture>
                    //{
                    //    new Picture { Id = 3, Name = "macbook", Path = "/images/products/macbook.jpg" }
                    //}
                }
            };

            builder.Entity<Category>().HasData(categories);
            builder.Entity<Manufacturer>().HasData(manufacturers);
            builder.Entity<Product>().HasData(products);

            base.OnModelCreating(builder);
        }
    }
}

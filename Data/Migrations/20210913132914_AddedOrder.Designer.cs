﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XESShop.Data;

namespace XESShop.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210913132914_AddedOrder")]
    partial class AddedOrder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("XESShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Электроника"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Компьютеры и ноутбуки"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Смартфоны"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Товары для геймеров"
                        });
                });

            modelBuilder.Entity("XESShop.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WriterId")
                        .HasColumnType("int");

                    b.Property<string>("WriterId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WriterId1");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("XESShop.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LogoId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LogoId");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Microsoft"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Xiaomi"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Electronic Arts"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Samsung"
                        });
                });

            modelBuilder.Entity("XESShop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("XESShop.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Picture");
                });

            modelBuilder.Entity("XESShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BigName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BigName = "Мобильный телефон Apple iPhone 12 256GB Purple Официальная гарантия",
                            CategoryId = 3,
                            Description = "Экран (6.7, OLED (Super Retina XDR), 2778x1284) /Apple A14 Bionic / тройная основная камера: 12 Мп + 12 Мп + 12 Мп,фронтальная камера: 12 Мп / 128 ГБ встроенной памяти/ 3G / LTE / 5G / GPS / Nano - SIM / iOS 14",
                            ManufacturerId = 1,
                            Name = "iPhone 12 Pro Max",
                            Price = 43999m
                        },
                        new
                        {
                            Id = 2,
                            BigName = "Мобильный телефон Samsung Galaxy S21 Ultra 12/256GB Phantom Black (SM-G998BZKGSEK)",
                            CategoryId = 3,
                            Description = "Экран (6.8, Dynamic AMOLED 2X, 3200x1440)/Samsung Exynos 2100(1 x 2.9 ГГц + 3 x 2.8 ГГц + 4 x 2.2 ГГц) /основная квадро - камера: 108 Мп + 12 Мп + 10 Мп + 10 Мп, фронтальная: 40 Мп /RAM 12 ГБ / 256 ГБ встроенной памяти / 3G / LTE / 5G / GPS /поддержка 2х SIM-карт(Nano - SIM) / Android 11.0 / 5000 мА* ч",
                            ManufacturerId = 5,
                            Name = "Samsung Galaxy S21 Ultra",
                            Price = 40000m
                        },
                        new
                        {
                            Id = 3,
                            BigName = "Ноутбук Apple MacBook Air 13, M1 256GB 2020 (MGN63) Space Gray",
                            CategoryId = 3,
                            Description = "Экран 13.3 Retina (2560x1600) WQXGA, глянцевый /Apple M1 / RAM 8 ГБ / SSD 256 ГБ / Apple M1 Graphics / Wi-Fi /Bluetooth / macOS Big Sur / 1.29 кг / серый",
                            ManufacturerId = 5,
                            Name = "Apple MacBook Air 13",
                            Price = 40000m
                        });
                });

            modelBuilder.Entity("XESShop.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AvatarId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("IdentityId")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("XESShop.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("XESShop.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XESShop.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("XESShop.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("XESShop.Models.Category", b =>
                {
                    b.HasOne("XESShop.Models.Picture", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("XESShop.Models.Comment", b =>
                {
                    b.HasOne("XESShop.Models.Manufacturer", null)
                        .WithMany("Сomments")
                        .HasForeignKey("ManufacturerId");

                    b.HasOne("XESShop.Models.Product", null)
                        .WithMany("Сomments")
                        .HasForeignKey("ProductId");

                    b.HasOne("XESShop.Models.User", "Writer")
                        .WithMany("Comments")
                        .HasForeignKey("WriterId1");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("XESShop.Models.Manufacturer", b =>
                {
                    b.HasOne("XESShop.Models.Picture", "Logo")
                        .WithMany()
                        .HasForeignKey("LogoId");

                    b.Navigation("Logo");
                });

            modelBuilder.Entity("XESShop.Models.Order", b =>
                {
                    b.HasOne("XESShop.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId1");

                    b.Navigation("User");
                });

            modelBuilder.Entity("XESShop.Models.Picture", b =>
                {
                    b.HasOne("XESShop.Models.Product", null)
                        .WithMany("Photos")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("XESShop.Models.Product", b =>
                {
                    b.HasOne("XESShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XESShop.Models.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XESShop.Models.Order", null)
                        .WithMany("Product")
                        .HasForeignKey("OrderId");

                    b.Navigation("Category");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("XESShop.Models.User", b =>
                {
                    b.OwnsOne("XESShop.Models.Identity", "Identity", b1 =>
                        {
                            b1.Property<string>("UserId1")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<int>("AddressId")
                                .HasColumnType("int");

                            b1.Property<int>("Age")
                                .HasColumnType("int");

                            b1.Property<string>("Email")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("FirstName")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Id")
                                .HasColumnType("int");

                            b1.Property<string>("LastName")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Phone")
                                .HasColumnType("int");

                            b1.Property<string>("SecondName")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("UserId")
                                .HasColumnType("int");

                            b1.HasKey("UserId1");

                            b1.ToTable("AspNetUsers");

                            b1.WithOwner("User")
                                .HasForeignKey("UserId1");

                            b1.OwnsOne("XESShop.Models.Address", "Address", b2 =>
                                {
                                    b2.Property<string>("IdentityUserId1")
                                        .HasColumnType("nvarchar(450)");

                                    b2.Property<string>("City")
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<int>("Id")
                                        .HasColumnType("int");

                                    b2.Property<int>("IdentityId")
                                        .HasColumnType("int");

                                    b2.Property<string>("Postcode")
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("Street")
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("IdentityUserId1");

                                    b2.ToTable("AspNetUsers");

                                    b2.WithOwner("Identity")
                                        .HasForeignKey("IdentityUserId1");

                                    b2.Navigation("Identity");
                                });

                            b1.Navigation("Address");

                            b1.Navigation("User");
                        });

                    b.OwnsOne("XESShop.Models.UserAvatar", "Avatar", b1 =>
                        {
                            b1.Property<string>("UserId1")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<int>("Id")
                                .HasColumnType("int");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Path")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("UserId")
                                .HasColumnType("int");

                            b1.HasKey("UserId1");

                            b1.ToTable("AspNetUsers");

                            b1.WithOwner("User")
                                .HasForeignKey("UserId1");

                            b1.Navigation("User");
                        });

                    b.Navigation("Avatar");

                    b.Navigation("Identity");
                });

            modelBuilder.Entity("XESShop.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("XESShop.Models.Manufacturer", b =>
                {
                    b.Navigation("Сomments");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("XESShop.Models.Order", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("XESShop.Models.Product", b =>
                {
                    b.Navigation("Сomments");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("XESShop.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
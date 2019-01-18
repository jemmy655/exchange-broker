﻿// <auto-generated />
using System;
using ExchangeBroker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExchangeBroker.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181219093458_Added account pools")]
    partial class Addedaccountpools
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ExchangeBroker.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AspNetRoleId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ExchangeBroker.Models.AppParam", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("param_name")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnName("param_value")
                        .HasColumnType("varchar(1000)");

                    b.HasKey("ID");

                    b.ToTable("AppParam");
                });

            modelBuilder.Entity("ExchangeBroker.Models.Exchange", b =>
                {
                    b.Property<string>("ExchangeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(128)");

                    b.Property<decimal>("BuyAmount");

                    b.Property<string>("BuyCurrency")
                        .IsRequired();

                    b.Property<string>("BuyerTransactionId");

                    b.Property<int>("BuyerTransactionStatus");

                    b.Property<string>("BuyerWallet")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<decimal>("ExchangeBrokerFee");

                    b.Property<decimal>("GraftToUsdRate");

                    b.Property<int>("PayAddressIndex");

                    b.Property<string>("PayWalletAddress")
                        .IsRequired();

                    b.Property<decimal>("ReceivedAmount");

                    b.Property<int>("ReceivedConfirmations");

                    b.Property<decimal>("SellAmount");

                    b.Property<string>("SellCurrency")
                        .IsRequired();

                    b.Property<decimal>("SellToUsdRate");

                    b.Property<sbyte>("Status");

                    b.HasKey("ExchangeId");

                    b.ToTable("Exchange");
                });

            modelBuilder.Entity("ExchangeBroker.Models.Payment", b =>
                {
                    b.Property<string>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<decimal>("ExchangeBrokerFee");

                    b.Property<decimal>("GraftToSaleRate");

                    b.Property<decimal>("MerchantAmount");

                    b.Property<string>("MerchantTransactionId");

                    b.Property<int>("MerchantTransactionStatus");

                    b.Property<string>("MerchantWallet");

                    b.Property<int>("PayAddressIndex");

                    b.Property<decimal>("PayAmount");

                    b.Property<string>("PayCurrency")
                        .IsRequired();

                    b.Property<decimal>("PayToSaleRate");

                    b.Property<string>("PayWalletAddress")
                        .IsRequired();

                    b.Property<string>("ProviderTransactionId");

                    b.Property<int>("ProviderTransactionStatus");

                    b.Property<decimal>("ReceivedAmount");

                    b.Property<int>("ReceivedConfirmations");

                    b.Property<decimal>("SaleAmount");

                    b.Property<string>("SaleCurrency")
                        .IsRequired();

                    b.Property<decimal>("ServiceProviderFee");

                    b.Property<string>("ServiceProviderWallet");

                    b.Property<sbyte>("Status");

                    b.HasKey("PaymentId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Graft.Infrastructure.AccountPool.AccountPoolItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<long>("Balance");

                    b.Property<string>("CurrencyName");

                    b.Property<bool>("IsProcessed")
                        .IsConcurrencyToken();

                    b.Property<string>("LastTransactionHash");

                    b.HasKey("Id");

                    b.ToTable("AccountPools");
                });

            modelBuilder.Entity("GraftLib.Models.TransactionRequest", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<ulong>("Amount");

                    b.Property<DateTime>("LastUpdatedTime")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Status")
                        .IsConcurrencyToken();

                    b.Property<string>("TxId");

                    b.HasKey("Id");

                    b.ToTable("TransactionRequests");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ExchangeBroker.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ExchangeBroker.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExchangeBroker.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ExchangeBroker.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

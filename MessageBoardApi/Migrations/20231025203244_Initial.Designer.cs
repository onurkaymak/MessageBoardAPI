﻿// <auto-generated />
using System;
using MessageBoardApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MessageBoardApi.Migrations
{
    [DbContext(typeof(MessageBoardApiContext))]
    [Migration("20231025203244_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageBoardApi.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "sda",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "04ff212c-912f-42b2-92db-9627351bce3d",
                            Email = "joey@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "JOEY@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDiuH29T0iVs0hMpm3TN0fjPa0KyepKgWFx5G4tSNZ0gfEzr6U5YH1k+kZL8G54FEg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f8d33b0-110c-42a9-a8d0-2b8b4119e68b",
                            TwoFactorEnabled = false,
                            UserName = "Joey"
                        },
                        new
                        {
                            Id = "abc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "463be458-38ed-4e2e-9bff-553c733fce49",
                            Email = "richard@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "RICHARD@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHgS8xF9ssGMh1p8FJLdDfmxmqYbLvsKIMK8RVU+j/+4WpbJuRKyHf6wOo0UdZDfcQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "074444e3-41c7-4103-843b-8f306c2cab4e",
                            TwoFactorEnabled = false,
                            UserName = "Richard"
                        },
                        new
                        {
                            Id = "frg",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b3c3fbe-e1ed-43d3-8dde-f88d55975d42",
                            Email = "onur@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ONUR@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEI31zhgXDyD/gON33JKyPQ3INbr78sPN9Cldw25+C7s82PM5T+/QtMc+Ovv6myzwnA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "72eec926-f04a-437a-b1fa-8796e2525598",
                            TwoFactorEnabled = false,
                            UserName = "Onur"
                        });
                });

            modelBuilder.Entity("MessageBoardApi.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            Name = "Spider-Man"
                        },
                        new
                        {
                            GroupId = 2,
                            Name = "Witcher"
                        },
                        new
                        {
                            GroupId = 3,
                            Name = "Costumes"
                        });
                });

            modelBuilder.Entity("MessageBoardApi.Models.GroupUser", b =>
                {
                    b.Property<int>("GroupUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("GroupUserId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("GroupUsers");

                    b.HasData(
                        new
                        {
                            GroupUserId = 1,
                            GroupId = 1,
                            UserId = "abc"
                        },
                        new
                        {
                            GroupUserId = 2,
                            GroupId = 3,
                            UserId = "sda"
                        },
                        new
                        {
                            GroupUserId = 3,
                            GroupId = 2,
                            UserId = "frg"
                        },
                        new
                        {
                            GroupUserId = 4,
                            GroupId = 2,
                            UserId = "abc"
                        },
                        new
                        {
                            GroupUserId = 5,
                            GroupId = 2,
                            UserId = "sda"
                        });
                });

            modelBuilder.Entity("MessageBoardApi.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("MessageId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            MessageId = 1,
                            Date = new DateTime(2022, 12, 8, 8, 15, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 1,
                            Text = "This new Spider-Man game looks awesome!",
                            UserId = "abc"
                        },
                        new
                        {
                            MessageId = 2,
                            Date = new DateTime(2023, 3, 21, 6, 30, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 3,
                            Text = "What did ya'll get for candy? I got rocks.",
                            UserId = "sda"
                        },
                        new
                        {
                            MessageId = 3,
                            Date = new DateTime(2020, 5, 13, 8, 11, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 2,
                            Text = "I hate Ciri!",
                            UserId = "frg"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MessageBoardApi.Models.GroupUser", b =>
                {
                    b.HasOne("MessageBoardApi.Models.Group", "Group")
                        .WithMany("JoinEntities")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MessageBoardApi.Models.ApplicationUser", "User")
                        .WithMany("JoinEntities")
                        .HasForeignKey("UserId");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MessageBoardApi.Models.Message", b =>
                {
                    b.HasOne("MessageBoardApi.Models.Group", "Group")
                        .WithMany("Messages")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MessageBoardApi.Models.ApplicationUser", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId");

                    b.Navigation("Group");

                    b.Navigation("User");
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
                    b.HasOne("MessageBoardApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MessageBoardApi.Models.ApplicationUser", null)
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

                    b.HasOne("MessageBoardApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MessageBoardApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MessageBoardApi.Models.ApplicationUser", b =>
                {
                    b.Navigation("JoinEntities");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("MessageBoardApi.Models.Group", b =>
                {
                    b.Navigation("JoinEntities");

                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}

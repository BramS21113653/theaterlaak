﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using theaterlaak.Data;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.Key", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Algorithm")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("DataProtected")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsX509Certificate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Use")
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Use");

                    b.ToTable("Keys");
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("TEXT");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Key");

                    b.HasIndex("ConsumedTime");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

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
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("theaterlaak.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("adres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("geboortedatum")
                        .HasColumnType("TEXT");

                    b.Property<int>("leeftijdscategorie")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("theaterlaak.Models.Boeking", b =>
                {
                    b.Property<string>("BoekingId")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ZaalId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("applicationUserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BoekingId");

                    b.HasIndex("ZaalId");

                    b.HasIndex("applicationUserId");

                    b.ToTable("Boekingen");
                });

            modelBuilder.Entity("theaterlaak.Models.Donatie", b =>
                {
                    b.Property<string>("DonatieId")
                        .HasColumnType("TEXT");

                    b.Property<int>("bedrag")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("datum")
                        .HasColumnType("TEXT");

                    b.HasKey("DonatieId");

                    b.ToTable("Donaties");
                });

            modelBuilder.Entity("theaterlaak.Models.Gelegenheid", b =>
                {
                    b.Property<string>("GelegenheidId")
                        .HasColumnType("TEXT");

                    b.Property<string>("VoorstellingId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ZaalId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("aanvangstijd")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("eindtijd")
                        .HasColumnType("TEXT");

                    b.HasKey("GelegenheidId");

                    b.HasIndex("VoorstellingId");

                    b.HasIndex("ZaalId");

                    b.ToTable("Gelegenheden");
                });

            modelBuilder.Entity("theaterlaak.Models.Groep", b =>
                {
                    b.Property<string>("GroepId")
                        .HasColumnType("TEXT");

                    b.Property<string>("VoorstellingId")
                        .HasColumnType("TEXT");

                    b.Property<string>("naam")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("website")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("GroepId");

                    b.HasIndex("VoorstellingId");

                    b.ToTable("Groepen");
                });

            modelBuilder.Entity("theaterlaak.Models.Interesse", b =>
                {
                    b.Property<int>("InteresseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("interesse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("InteresseId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Interesses");
                });

            modelBuilder.Entity("theaterlaak.Models.Ticket", b =>
                {
                    b.Property<string>("TicketId")
                        .HasColumnType("TEXT");

                    b.Property<string>("BoekingId")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VoorstellingId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ZaalId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ZitplaatsId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("applicationUserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("prijs")
                        .HasColumnType("REAL");

                    b.HasKey("TicketId");

                    b.HasIndex("BoekingId");

                    b.HasIndex("VoorstellingId");

                    b.HasIndex("ZaalId");

                    b.HasIndex("ZitplaatsId");

                    b.HasIndex("applicationUserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("theaterlaak.Models.Voorstelling", b =>
                {
                    b.Property<string>("VoorstellingId")
                        .HasColumnType("TEXT");

                    b.Property<string>("omschrijving")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("prijs")
                        .HasColumnType("INTEGER");

                    b.Property<string>("titel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VoorstellingId");

                    b.ToTable("Voorstellingen");
                });

            modelBuilder.Entity("theaterlaak.Models.Zaal", b =>
                {
                    b.Property<string>("ZaalId")
                        .HasColumnType("TEXT");

                    b.Property<int>("aantalZitplaatsen")
                        .HasColumnType("INTEGER");

                    b.Property<int>("zaalnummer")
                        .HasColumnType("INTEGER");

                    b.HasKey("ZaalId");

                    b.ToTable("Zalen");
                });

            modelBuilder.Entity("theaterlaak.Models.Zitplaats", b =>
                {
                    b.Property<string>("ZitplaatsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ZaalId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("rangnummer")
                        .HasColumnType("INTEGER");

                    b.Property<int>("stoelnummer")
                        .HasColumnType("INTEGER");

                    b.HasKey("ZitplaatsId");

                    b.HasIndex("ZaalId");

                    b.ToTable("Zitplaatsen");
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
                    b.HasOne("theaterlaak.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("theaterlaak.Models.ApplicationUser", null)
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

                    b.HasOne("theaterlaak.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("theaterlaak.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("theaterlaak.Models.Boeking", b =>
                {
                    b.HasOne("theaterlaak.Models.Zaal", "zaal")
                        .WithMany("Boekingen")
                        .HasForeignKey("ZaalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("theaterlaak.Models.ApplicationUser", "applicationUser")
                        .WithMany()
                        .HasForeignKey("applicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("applicationUser");

                    b.Navigation("zaal");
                });

            modelBuilder.Entity("theaterlaak.Models.Gelegenheid", b =>
                {
                    b.HasOne("theaterlaak.Models.Voorstelling", "voorstelling")
                        .WithMany("Gelegenheden")
                        .HasForeignKey("VoorstellingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("theaterlaak.Models.Zaal", "zaal")
                        .WithMany("Gelegenheden")
                        .HasForeignKey("ZaalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("voorstelling");

                    b.Navigation("zaal");
                });

            modelBuilder.Entity("theaterlaak.Models.Groep", b =>
                {
                    b.HasOne("theaterlaak.Models.Voorstelling", null)
                        .WithMany("Groepen")
                        .HasForeignKey("VoorstellingId");
                });

            modelBuilder.Entity("theaterlaak.Models.Interesse", b =>
                {
                    b.HasOne("theaterlaak.Models.ApplicationUser", null)
                        .WithMany("interesses")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("theaterlaak.Models.Ticket", b =>
                {
                    b.HasOne("theaterlaak.Models.Boeking", null)
                        .WithMany("Tickets")
                        .HasForeignKey("BoekingId");

                    b.HasOne("theaterlaak.Models.Voorstelling", "voorstelling")
                        .WithMany("Tickets")
                        .HasForeignKey("VoorstellingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("theaterlaak.Models.Zaal", "zaal")
                        .WithMany("Tickets")
                        .HasForeignKey("ZaalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("theaterlaak.Models.Zitplaats", "zitplaats")
                        .WithMany("Tickets")
                        .HasForeignKey("ZitplaatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("theaterlaak.Models.ApplicationUser", "applicationUser")
                        .WithMany()
                        .HasForeignKey("applicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("applicationUser");

                    b.Navigation("voorstelling");

                    b.Navigation("zaal");

                    b.Navigation("zitplaats");
                });

            modelBuilder.Entity("theaterlaak.Models.Zitplaats", b =>
                {
                    b.HasOne("theaterlaak.Models.Zaal", "zaal")
                        .WithMany("Zitplaatsen")
                        .HasForeignKey("ZaalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("zaal");
                });

            modelBuilder.Entity("theaterlaak.Models.ApplicationUser", b =>
                {
                    b.Navigation("interesses");
                });

            modelBuilder.Entity("theaterlaak.Models.Boeking", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("theaterlaak.Models.Voorstelling", b =>
                {
                    b.Navigation("Gelegenheden");

                    b.Navigation("Groepen");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("theaterlaak.Models.Zaal", b =>
                {
                    b.Navigation("Boekingen");

                    b.Navigation("Gelegenheden");

                    b.Navigation("Tickets");

                    b.Navigation("Zitplaatsen");
                });

            modelBuilder.Entity("theaterlaak.Models.Zitplaats", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Module4_ModuleHW.Configurations;

#nullable disable

namespace Module4_ModuleHW.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Module4_ModuleHW.DTO.Breed", b =>
                {
                    b.Property<int>("BreedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BreedId"));

                    b.Property<string>("BreedName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("BreedId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Breed");
                });

            modelBuilder.Entity("Module4_ModuleHW.DTO.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Module4_ModuleHW.DTO.Location", b =>
                {
                    b.Property<int>("locationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("locationId"));

                    b.Property<string>("locationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("locationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Module4_ModuleHW.DTO.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OwnerId"));

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OwnerId");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("Module4_ModuleHW.DTO.Pet", b =>
                {
                    b.Property<int>("petId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("petId"));

                    b.Property<int?>("breedId")
                        .HasColumnType("int");

                    b.Property<int?>("categoryId")
                        .HasColumnType("int");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("locationId")
                        .HasColumnType("int");

                    b.Property<int?>("ownerId")
                        .HasColumnType("int");

                    b.Property<float>("petAge")
                        .HasColumnType("real");

                    b.Property<string>("petDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("petName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("petId");

                    b.HasIndex("breedId");

                    b.HasIndex("categoryId");

                    b.HasIndex("locationId");

                    b.HasIndex("ownerId");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("Module4_ModuleHW.DTO.Breed", b =>
                {
                    b.HasOne("Module4_ModuleHW.DTO.Category", "Category")
                        .WithMany("Breeds")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Module4_ModuleHW.DTO.Pet", b =>
                {
                    b.HasOne("Module4_ModuleHW.DTO.Breed", "Breed")
                        .WithMany("Pets")
                        .HasForeignKey("breedId");

                    b.HasOne("Module4_ModuleHW.DTO.Category", "Category")
                        .WithMany("Pets")
                        .HasForeignKey("categoryId");

                    b.HasOne("Module4_ModuleHW.DTO.Location", "Location")
                        .WithMany("Pets")
                        .HasForeignKey("locationId");

                    b.HasOne("Module4_ModuleHW.DTO.Owner", "Owner")
                        .WithMany("Pets")
                        .HasForeignKey("ownerId");

                    b.Navigation("Breed");

                    b.Navigation("Category");

                    b.Navigation("Location");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Module4_ModuleHW.DTO.Breed", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("Module4_ModuleHW.DTO.Category", b =>
                {
                    b.Navigation("Breeds");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("Module4_ModuleHW.DTO.Location", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("Module4_ModuleHW.DTO.Owner", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}

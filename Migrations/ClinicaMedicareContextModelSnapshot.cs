﻿// <auto-generated />
using ClinicaMedicare.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicaMedicare.Migrations
{
    [DbContext(typeof(ClinicaMedicareContext))]
    partial class ClinicaMedicareContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("ClinicaMedicare.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Especialidad")
                        .HasColumnType("TEXT");

                    b.Property<int>("Experiencia")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Doctor");
                });
#pragma warning restore 612, 618
        }
    }
}
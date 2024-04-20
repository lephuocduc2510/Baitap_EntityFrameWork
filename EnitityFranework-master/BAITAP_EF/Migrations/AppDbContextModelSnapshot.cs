﻿// <auto-generated />
using BAITAP_EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BAITAP_EF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.3.24172.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BAITAP_EF.Models.Faculty", b =>
                {
                    b.Property<int>("FacultyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacultyID"));

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacultyID");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            FacultyID = 1,
                            FacultyName = "Cong Nghe So"
                        },
                        new
                        {
                            FacultyID = 2,
                            FacultyName = "Co Khi"
                        },
                        new
                        {
                            FacultyID = 3,
                            FacultyName = "Dien-Dien Tu"
                        });
                });

            modelBuilder.Entity("BAITAP_EF.Models.Lop", b =>
                {
                    b.Property<int>("classID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("classID"));

                    b.Property<int>("FacultyID")
                        .HasColumnType("int");

                    b.Property<string>("className")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("classID");

                    b.HasIndex("FacultyID");

                    b.ToTable("Lops");

                    b.HasData(
                        new
                        {
                            classID = 1,
                            FacultyID = 1,
                            className = "21T1"
                        },
                        new
                        {
                            classID = 2,
                            FacultyID = 1,
                            className = "21T2"
                        },
                        new
                        {
                            classID = 3,
                            FacultyID = 1,
                            className = "21T3"
                        },
                        new
                        {
                            classID = 4,
                            FacultyID = 1,
                            className = "20T3"
                        });
                });

            modelBuilder.Entity("BAITAP_EF.Models.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("classID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("classID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Quang Trị",
                            Age = 20,
                            Name = "Le Phuoc Duc",
                            Phone = "0123456789",
                            classID = 3
                        },
                        new
                        {
                            Id = 2,
                            Address = "Quang Trị",
                            Age = 20,
                            Name = "Hoang Ngoc triet",
                            Phone = "1234567890",
                            classID = 1
                        },
                        new
                        {
                            Id = 3,
                            Address = "Quang Nam",
                            Age = 20,
                            Name = "Le Thi Hong Nhung",
                            Phone = "0123456789",
                            classID = 2
                        },
                        new
                        {
                            Id = 4,
                            Address = "Quang Nam",
                            Age = 21,
                            Name = "Nguyen Van A",
                            Phone = "1234567890",
                            classID = 4
                        });
                });

            modelBuilder.Entity("BAITAP_EF.Models.Lop", b =>
                {
                    b.HasOne("BAITAP_EF.Models.Faculty", "Faculty")
                        .WithMany("Lops")
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("BAITAP_EF.Models.Students", b =>
                {
                    b.HasOne("BAITAP_EF.Models.Lop", "Class")
                        .WithMany("Students")
                        .HasForeignKey("classID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("BAITAP_EF.Models.Faculty", b =>
                {
                    b.Navigation("Lops");
                });

            modelBuilder.Entity("BAITAP_EF.Models.Lop", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}

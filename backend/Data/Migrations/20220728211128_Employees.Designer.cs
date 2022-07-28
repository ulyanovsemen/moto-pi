﻿// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220728211128_Employees")]
    partial class Employees
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.Entities.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Fio")
                        .HasColumnType("text")
                        .HasColumnName("fio");

                    b.Property<string>("TelNumber")
                        .HasColumnType("text")
                        .HasColumnName("tel_number");

                    b.HasKey("Id")
                        .HasName("pk_employees");

                    b.ToTable("employees", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Fio = "Иванов Иван Иванович",
                            TelNumber = "8-800-555-3535"
                        });
                });

            modelBuilder.Entity("Data.Entities.Part", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Model")
                        .HasColumnType("text")
                        .HasColumnName("model");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.Property<string>("Number")
                        .HasColumnType("text")
                        .HasColumnName("number");

                    b.Property<long>("PartTypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("part_type_id");

                    b.HasKey("Id")
                        .HasName("pk_parts");

                    b.HasIndex("PartTypeId")
                        .HasDatabaseName("ix_parts_part_type_id");

                    b.ToTable("parts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Model = "BMW",
                            Name = "Стойка амортизатора",
                            Number = "12345QWE",
                            PartTypeId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            Model = "BMW",
                            Name = "Пружина",
                            Number = "ZXC123",
                            PartTypeId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            Model = "Bosh",
                            Name = "Поршень",
                            Number = "ZXC123",
                            PartTypeId = 2L
                        });
                });

            modelBuilder.Entity("Data.Entities.PartType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.HasKey("Id")
                        .HasName("pk_part_types");

                    b.ToTable("part_types", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Подвеска"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Двигатель"
                        });
                });

            modelBuilder.Entity("Data.Entities.Work", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.Property<long>("WorkTypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("work_type_id");

                    b.HasKey("Id")
                        .HasName("pk_works");

                    b.HasIndex("WorkTypeId")
                        .HasDatabaseName("ix_works_work_type_id");

                    b.ToTable("works", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Замена стойки амортизатора",
                            WorkTypeId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Замена пружины",
                            WorkTypeId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Замена масла",
                            WorkTypeId = 2L
                        });
                });

            modelBuilder.Entity("Data.Entities.WorkType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.HasKey("Id")
                        .HasName("pk_work_types");

                    b.ToTable("work_types", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Подвеска"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Двигатель"
                        });
                });

            modelBuilder.Entity("Data.Entities.Part", b =>
                {
                    b.HasOne("Data.Entities.PartType", "Type")
                        .WithMany()
                        .HasForeignKey("PartTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_parts_part_types_part_type_id");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Data.Entities.Work", b =>
                {
                    b.HasOne("Data.Entities.WorkType", "Type")
                        .WithMany()
                        .HasForeignKey("WorkTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_works_work_types_work_type_id");

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}

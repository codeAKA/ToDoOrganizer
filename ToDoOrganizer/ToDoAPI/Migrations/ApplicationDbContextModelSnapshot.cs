﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ToDoAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "5.0.0-preview.3.20181.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Entities.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .HasColumnType("character varying(2000)")
                        .HasMaxLength(2000);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<List<string>>("Priorities")
                        .HasColumnType("text[]");

                    b.Property<List<string>>("Status")
                        .HasColumnType("text[]");

                    b.Property<string>("Title")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("Entities.Models.TodosList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<List<int>>("TodoId")
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.ToTable("TodosLists");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<List<int>>("TodoId")
                        .HasColumnType("integer[]");

                    b.Property<List<int>>("TodosListId")
                        .HasColumnType("integer[]");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Models.Todo", b =>
                {
                    b.HasOne("Entities.Models.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");
                });
#pragma warning restore 612, 618
        }
    }
}

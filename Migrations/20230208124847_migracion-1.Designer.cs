﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UploadImageToDatabase.DbContexts;

#nullable disable

namespace UploadImageToDatabase.Migrations
{
    [DbContext(typeof(PostgreSqlContext))]
    [Migration("20230208124847_migracion-1")]
    partial class migracion1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UploadImageToDatabase.Entities.Alumno", b =>
                {
                    b.Property<int>("Alumno_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Alumno_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Alumno_id"));

                    b.Property<string>("Alumno_imagen")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Alumno_imagen");

                    b.Property<string>("Alumno_nombre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("Alumno_nombre");

                    b.Property<DateTime>("Md_date")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("Md_date");

                    b.Property<Guid>("Md_uuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Md_uuid");

                    b.HasKey("Alumno_id");

                    b.ToTable("alumno", "public");
                });
#pragma warning restore 612, 618
        }
    }
}
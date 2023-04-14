﻿// <auto-generated />
using Kolekcjoner_EF.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KolekcjonerAPI.Migrations
{
    [DbContext(typeof(KolekcjonerContext))]
    [Migration("20230414101025_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KolekcjonerModel.Models.Collection", b =>
                {
                    b.Property<int>("Id_Collection")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Collection"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_PropertyDefinition")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Collection");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("KolekcjonerModel.Models.CollectionDefinition", b =>
                {
                    b.Property<int>("Id_CollectionDefinition")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_CollectionDefinition"));

                    b.Property<int>("Id_Property")
                        .HasColumnType("int");

                    b.HasKey("Id_CollectionDefinition");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("KolekcjonerModel.Models.CollectionPosition", b =>
                {
                    b.Property<int>("Id_CollectionPosition")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_CollectionPosition"));

                    b.Property<int>("Id_Collection")
                        .HasColumnType("int");

                    b.Property<int>("Id_PositionProperty")
                        .HasColumnType("int");

                    b.Property<int>("SortNumber")
                        .HasColumnType("int");

                    b.HasKey("Id_CollectionPosition");

                    b.ToTable("CollectionPositions");
                });

            modelBuilder.Entity("KolekcjonerModel.Models.PositionProperty", b =>
                {
                    b.Property<int>("Id_PositionProperty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_PositionProperty"));

                    b.Property<int>("Id_Property")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_PositionProperty");

                    b.ToTable("PositionProperties");
                });

            modelBuilder.Entity("KolekcjonerModel.Models.Property", b =>
                {
                    b.Property<int>("Id_Property")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Property"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_PropertyType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Property");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("KolekcjonerModel.Models.PropertyType", b =>
                {
                    b.Property<int>("Id_PropertyType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_PropertyType"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_PropertyType");

                    b.ToTable("PropertyTypes");
                });
#pragma warning restore 612, 618
        }
    }
}

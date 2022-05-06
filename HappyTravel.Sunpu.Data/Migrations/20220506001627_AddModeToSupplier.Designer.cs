﻿// <auto-generated />
using System;
using System.Collections.Generic;
using HappyTravel.MapperContracts.Public.Accommodations.Enums;
using HappyTravel.Sunpu.Data;
using HappyTravel.Sunpu.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HappyTravel.Sunpu.Data.Migrations
{
    [DbContext(typeof(SunpuContext))]
    [Migration("20220506001627_AddModeToSupplier")]
    partial class AddModeToSupplier
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HappyTravel.Sunpu.Data.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConnectorGrpcEndpoint")
                        .HasColumnType("text");

                    b.Property<string>("ConnectorUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Dictionary<string, string>>("CustomHeaders")
                        .HasColumnType("jsonb");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsMultiRoomFlowSupported")
                        .HasColumnType("boolean");

                    b.Property<int>("Mode")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Contact>("PrimaryContact")
                        .HasColumnType("jsonb");

                    b.Property<Dictionary<AccommodationDataTypes, int>>("Priority")
                        .HasColumnType("jsonb");

                    b.Property<List<Contact>>("ReservationsContacts")
                        .HasColumnType("jsonb");

                    b.Property<List<Contact>>("SupportContacts")
                        .HasColumnType("jsonb");

                    b.Property<string>("WebSite")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Suppliers", (string)null);
                });

            modelBuilder.Entity("HappyTravel.Sunpu.Data.Models.SupplierActivationHistoryEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SupplierId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("SupplierActivationHistory", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCSA.WebAPI.FlightsData.Data;


#nullable disable

namespace TCSA.WebAPI.FlightsData2.Migrations
{
    [DbContext(typeof(FlightsDbContext2))]
    [Migration("20241207233350_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("TCSA.WebAPI.FlightsData2.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AirlineName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ArrivalAirportCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ArrivalDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartureAirportCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DepartureDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("FlightNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PassengerCapacity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}

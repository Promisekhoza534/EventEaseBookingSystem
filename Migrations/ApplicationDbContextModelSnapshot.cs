
using System;
using EventEase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventEase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventEase.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("VenueId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("EventId");

                    b.HasIndex("VenueId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("EventEase.Models.BookingDetailsViewModel", b =>
                {
                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("CustomerContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VenueId")
                        .HasColumnType("int");

                    b.Property<string>("VenueName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);

                    b.ToView("BookingDetailsView", (string)null);
                });

            modelBuilder.Entity("EventEase.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VenueId")
                        .HasColumnType("int");

                    b.HasKey("EventId");

                    b.HasIndex("EventTypeId");

                    b.HasIndex("VenueId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EventEase.Models.EventType", b =>
                {
                    b.Property<int>("EventTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventTypeId"));

                    b.Property<string>("EventTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventTypeId");

                    b.ToTable("EventTypes");

                    b.HasData(
                        new
                        {
                            EventTypeId = 1,
                            EventTypeName = "Conference"
                        },
                        new
                        {
                            EventTypeId = 2,
                            EventTypeName = "Wedding"
                        },
                        new
                        {
                            EventTypeId = 3,
                            EventTypeName = "Concert"
                        },
                        new
                        {
                            EventTypeId = 4,
                            EventTypeName = "Workshop"
                        },
                        new
                        {
                            EventTypeId = 5,
                            EventTypeName = "Birthday"
                        },
                        new
                        {
                            EventTypeId = 6,
                            EventTypeName = "Corporate"
                        });
                });

            modelBuilder.Entity("EventEase.Models.Venue", b =>
                {
                    b.Property<int>("VenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VenueId"));

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VenueName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VenueId");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("EventEase.Models.Booking", b =>
                {
                    b.HasOne("EventEase.Models.Event", "Event")
                        .WithMany("Bookings")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EventEase.Models.Venue", "Venue")
                        .WithMany("Bookings")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("EventEase.Models.Event", b =>
                {
                    b.HasOne("EventEase.Models.EventType", "EventTypeNavigation")
                        .WithMany("Events")
                        .HasForeignKey("EventTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("EventEase.Models.Venue", "Venue")
                        .WithMany("Events")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("EventTypeNavigation");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("EventEase.Models.Event", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("EventEase.Models.EventType", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("EventEase.Models.Venue", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}

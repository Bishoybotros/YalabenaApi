﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YalabenaApi.Data;

#nullable disable

namespace YalabenaApi.Migrations
{
    [DbContext(typeof(YalabenaDbContext))]
    partial class YalabenaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YalabenaApi.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("YalabenaApi.Models.Activity", b =>
                {
                    b.Property<int>("Activity_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Activity_Id"));

                    b.Property<DateTime>("Activity_Duration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Activity_Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Activity_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Activity_Price")
                        .HasColumnType("int");

                    b.HasKey("Activity_Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("YalabenaApi.Models.ActivityTransportation", b =>
                {
                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int>("TransportId")
                        .HasColumnType("int");

                    b.HasKey("ActivityId", "TransportId");

                    b.HasIndex("TransportId");

                    b.ToTable("ActivityTransportations");
                });

            modelBuilder.Entity("YalabenaApi.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<int>("ItineraryID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethodPayment_Id")
                        .HasColumnType("int");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("ItineraryID");

                    b.HasIndex("PaymentMethodPayment_Id");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("YalabenaApi.Models.Itinerary", b =>
                {
                    b.Property<int>("ItineraryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItineraryID"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ItineraryActivities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItineraryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ItineraryID");

                    b.HasIndex("UserId");

                    b.ToTable("Itineraries");
                });

            modelBuilder.Entity("YalabenaApi.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethodPayment_Id")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("BookingId");

                    b.HasIndex("PaymentMethodPayment_Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("YalabenaApi.Models.PaymentMethod", b =>
                {
                    b.Property<int>("Payment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Payment_Id"));

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type_of_method")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Payment_Id");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("YalabenaApi.Models.Preference", b =>
                {
                    b.Property<int>("Prre_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Prre_Id"));

                    b.Property<int?>("Budget")
                        .HasColumnType("int");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("TransportType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Prre_Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Preference");
                });

            modelBuilder.Entity("YalabenaApi.Models.PreferenceTransportation", b =>
                {
                    b.Property<int>("PreferenceId")
                        .HasColumnType("int");

                    b.Property<int>("TransportId")
                        .HasColumnType("int");

                    b.HasKey("PreferenceId", "TransportId");

                    b.HasIndex("TransportId");

                    b.ToTable("PreferenceTransportations");
                });

            modelBuilder.Entity("YalabenaApi.Models.Review", b =>
                {
                    b.Property<int>("Review_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Review_Id"));

                    b.Property<int>("Activity_Id")
                        .HasColumnType("int");

                    b.Property<string>("Review_Feedback")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Review_Id");

                    b.HasIndex("Activity_Id");

                    b.HasIndex("UserId");

                    b.ToTable("UsersReviews");
                });

            modelBuilder.Entity("YalabenaApi.Models.Transportation", b =>
                {
                    b.Property<int>("Transport_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Transport_Id"));

                    b.Property<DateTime>("Activity_Duration")
                        .HasColumnType("datetime2");

                    b.Property<int>("Transport_Cost")
                        .HasColumnType("int");

                    b.Property<string>("Transport_Rout")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transport_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Transport_Id");

                    b.ToTable("Transportations");
                });

            modelBuilder.Entity("YalabenaApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phone")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("AccountId");

                    b.ToTable("GuestUsers");
                });

            modelBuilder.Entity("YalabenaApi.Models.UserActivity", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int>("ItineraryId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ActivityId", "ItineraryId");

                    b.HasIndex("ActivityId");

                    b.HasIndex("ItineraryId");

                    b.ToTable("UserActivities");
                });

            modelBuilder.Entity("YalabenaApi.Models.ActivityTransportation", b =>
                {
                    b.HasOne("YalabenaApi.Models.Activity", "Activity")
                        .WithMany("ActivityTransportations")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YalabenaApi.Models.Transportation", "Transportation")
                        .WithMany("ActivityTransportations")
                        .HasForeignKey("TransportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("Transportation");
                });

            modelBuilder.Entity("YalabenaApi.Models.Booking", b =>
                {
                    b.HasOne("YalabenaApi.Models.Itinerary", "Itinerary")
                        .WithMany("Bookings")
                        .HasForeignKey("ItineraryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YalabenaApi.Models.PaymentMethod", "PaymentMethod")
                        .WithMany("Bookings")
                        .HasForeignKey("PaymentMethodPayment_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YalabenaApi.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId");

                    b.Navigation("Itinerary");

                    b.Navigation("PaymentMethod");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YalabenaApi.Models.Itinerary", b =>
                {
                    b.HasOne("YalabenaApi.Models.User", "User")
                        .WithMany("Itineraries")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("YalabenaApi.Models.Payment", b =>
                {
                    b.HasOne("YalabenaApi.Models.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YalabenaApi.Models.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodPayment_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("YalabenaApi.Models.Preference", b =>
                {
                    b.HasOne("YalabenaApi.Models.User", "User")
                        .WithOne("UserPreferences")
                        .HasForeignKey("YalabenaApi.Models.Preference", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YalabenaApi.Models.PreferenceTransportation", b =>
                {
                    b.HasOne("YalabenaApi.Models.Preference", "Preference")
                        .WithMany("PreferenceTransportations")
                        .HasForeignKey("PreferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YalabenaApi.Models.Transportation", "Transportation")
                        .WithMany("PreferenceTransportations")
                        .HasForeignKey("TransportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Preference");

                    b.Navigation("Transportation");
                });

            modelBuilder.Entity("YalabenaApi.Models.Review", b =>
                {
                    b.HasOne("YalabenaApi.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("Activity_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YalabenaApi.Models.User", "Users")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("YalabenaApi.Models.User", b =>
                {
                    b.HasOne("YalabenaApi.Models.Account", null)
                        .WithMany("GuestUsers")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("YalabenaApi.Models.UserActivity", b =>
                {
                    b.HasOne("YalabenaApi.Models.Activity", "Activity")
                        .WithMany("UserActivities")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YalabenaApi.Models.Itinerary", "Itinerary")
                        .WithMany("Activities")
                        .HasForeignKey("ItineraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YalabenaApi.Models.User", "User")
                        .WithMany("Activities")
                        .HasForeignKey("UserId");

                    b.Navigation("Activity");

                    b.Navigation("Itinerary");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YalabenaApi.Models.Account", b =>
                {
                    b.Navigation("GuestUsers");
                });

            modelBuilder.Entity("YalabenaApi.Models.Activity", b =>
                {
                    b.Navigation("ActivityTransportations");

                    b.Navigation("UserActivities");
                });

            modelBuilder.Entity("YalabenaApi.Models.Itinerary", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("YalabenaApi.Models.PaymentMethod", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("YalabenaApi.Models.Preference", b =>
                {
                    b.Navigation("PreferenceTransportations");
                });

            modelBuilder.Entity("YalabenaApi.Models.Transportation", b =>
                {
                    b.Navigation("ActivityTransportations");

                    b.Navigation("PreferenceTransportations");
                });

            modelBuilder.Entity("YalabenaApi.Models.User", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Bookings");

                    b.Navigation("Itineraries");

                    b.Navigation("Reviews");

                    b.Navigation("UserPreferences")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

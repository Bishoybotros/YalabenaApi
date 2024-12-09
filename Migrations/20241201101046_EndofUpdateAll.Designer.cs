﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YalabenaApi.Data;

#nullable disable

namespace YalabenaApi.Migrations
{
    [DbContext(typeof(YalabenaDbContext))]
    [Migration("20241201101046_EndofUpdateAll")]
    partial class EndofUpdateAll
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YalabenaApi.Models.Activity", b =>
                {
                    b.Property<int>("Activity_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Activity_Id"));

                    b.Property<int>("Act_Itineraryid_fk")
                        .HasColumnType("int");

                    b.Property<int>("Act_Userid_fk")
                        .HasColumnType("int");

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

                    b.Property<int?>("ItineraryID")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Activity_Id");

                    b.HasIndex("ItineraryID");

                    b.HasIndex("UserId");

                    b.ToTable("Activities_Users");
                });

            modelBuilder.Entity("YalabenaApi.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<int>("B_Itineraryid_fk")
                        .HasColumnType("int");

                    b.Property<int>("B_PaymentMethodId")
                        .HasColumnType("int");

                    b.Property<int>("B_Userid_fk")
                        .HasColumnType("int");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingId");

                    b.HasIndex("B_Itineraryid_fk");

                    b.HasIndex("B_PaymentMethodId");

                    b.HasIndex("B_Userid_fk");

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

                    b.Property<int>("I_Userid_fk")
                        .HasColumnType("int");

                    b.Property<string>("ItineraryActivities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItineraryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ItineraryID");

                    b.HasIndex("I_Userid_fk");

                    b.ToTable("Itineraries");
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

                    b.Property<int>("P_userid_fk")
                        .HasColumnType("int");

                    b.Property<string>("TransportType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Prre_Id");

                    b.HasIndex("P_userid_fk");

                    b.ToTable("Preferences_Users");
                });

            modelBuilder.Entity("YalabenaApi.Models.Review", b =>
                {
                    b.Property<int>("Review_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Review_Id"));

                    b.Property<int>("Rev_activity_fk")
                        .HasColumnType("int");

                    b.Property<int>("Rev_userid_fk")
                        .HasColumnType("int");

                    b.Property<string>("Review_Feedback")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Review_Id");

                    b.HasIndex("Rev_activity_fk");

                    b.HasIndex("Rev_userid_fk");

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

                    b.Property<int?>("Activity_Id")
                        .HasColumnType("int");

                    b.Property<int>("Trans_Pref_Fk")
                        .HasColumnType("int");

                    b.Property<int>("Trans_activity_Fk")
                        .HasColumnType("int");

                    b.Property<int>("Transport_Cost")
                        .HasColumnType("int");

                    b.Property<string>("Transport_Rout")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transport_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Transport_Id");

                    b.HasIndex("Activity_Id");

                    b.HasIndex("Trans_Pref_Fk");

                    b.ToTable("Transportations");
                });

            modelBuilder.Entity("YalabenaApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

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

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preferences")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phone")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("GuestUsers");
                });

            modelBuilder.Entity("YalabenaApi.Models.Activity", b =>
                {
                    b.HasOne("YalabenaApi.Models.Itinerary", null)
                        .WithMany("Activities")
                        .HasForeignKey("ItineraryID");

                    b.HasOne("YalabenaApi.Models.User", null)
                        .WithMany("Activities")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("YalabenaApi.Models.Booking", b =>
                {
                    b.HasOne("YalabenaApi.Models.Itinerary", "Itinerary")
                        .WithMany("Bookings")
                        .HasForeignKey("B_Itineraryid_fk")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("YalabenaApi.Models.PaymentMethod", "PaymentMethod")
                        .WithMany("Bookings")
                        .HasForeignKey("B_PaymentMethodId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("YalabenaApi.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("B_Userid_fk")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Itinerary");

                    b.Navigation("PaymentMethod");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YalabenaApi.Models.Itinerary", b =>
                {
                    b.HasOne("YalabenaApi.Models.User", "User")
                        .WithMany("Itineraries")
                        .HasForeignKey("I_Userid_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("YalabenaApi.Models.Preference", b =>
                {
                    b.HasOne("YalabenaApi.Models.User", "User")
                        .WithMany("UserPreferences")
                        .HasForeignKey("P_userid_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("YalabenaApi.Models.Review", b =>
                {
                    b.HasOne("YalabenaApi.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("Rev_activity_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YalabenaApi.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("Rev_userid_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YalabenaApi.Models.Transportation", b =>
                {
                    b.HasOne("YalabenaApi.Models.Activity", null)
                        .WithMany("Transportations")
                        .HasForeignKey("Activity_Id");

                    b.HasOne("YalabenaApi.Models.Preference", "Preference")
                        .WithMany()
                        .HasForeignKey("Trans_Pref_Fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Preference");
                });

            modelBuilder.Entity("YalabenaApi.Models.Activity", b =>
                {
                    b.Navigation("Transportations");
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

            modelBuilder.Entity("YalabenaApi.Models.User", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Bookings");

                    b.Navigation("Itineraries");

                    b.Navigation("Reviews");

                    b.Navigation("UserPreferences");
                });
#pragma warning restore 612, 618
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using YalabenaApi.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace YalabenaApi.Data
{
  
    public class YalabenaDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)


          => optionsBuilder.UseSqlServer("Data Source=BISHOBONDOK;Initial Catalog=YalabenaDB;" +
              "Integrated Security=True;Trust Server Certificate=True");

        public YalabenaDbContext(DbContextOptions<YalabenaDbContext> options) : base(options) { }

        public DbSet<User> GuestUsers { get; set; }
        public DbSet<Itinerary> Itineraries { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Preference> Preferences_Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<UserActivity> UserActivities { get; set; }
        public DbSet<ActivityTransportation> ActivityTransportations { get; set; }
        public DbSet<Transportation> Transportations { get; set; }
        public DbSet<PreferenceTransportation> PreferenceTransportations { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<Review> UsersReviews { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Composite key for ActivityTransportation
            modelBuilder.Entity<ActivityTransportation>()
                .HasKey(at => new { at.ActivityId, at.TransportId });

            // Relationship configurations
            modelBuilder.Entity<ActivityTransportation>()
                .HasOne(at => at.Activity)
                .WithMany(a => a.ActivityTransportations)
                .HasForeignKey(at => at.ActivityId);

            modelBuilder.Entity<ActivityTransportation>()
                .HasOne(at => at.Transportation)
                .WithMany(t => t.ActivityTransportations)
                .HasForeignKey(at => at.TransportId);



            modelBuilder.Entity<PreferenceTransportation>()
    .HasKey(pt => new { pt.PreferenceId, pt.TransportId });

            modelBuilder.Entity<PreferenceTransportation>()
                .HasOne(pt => pt.Preference)
                .WithMany(p => p.PreferenceTransportations)
                .HasForeignKey(pt => pt.PreferenceId);

            modelBuilder.Entity<PreferenceTransportation>()
                .HasOne(pt => pt.Transportation)
                .WithMany(t => t.PreferenceTransportations)
                .HasForeignKey(pt => pt.TransportId);


            modelBuilder.Entity<UserActivity>()
        .HasKey(ua => new { ua.UserId, ua.ActivityId, ua.ItineraryId });

    // Relationships
    modelBuilder.Entity<UserActivity>()
        .HasOne(ua => ua.User)
        .WithMany(u => u.Activities)
        .HasForeignKey(ua => ua.UserId);

    modelBuilder.Entity<UserActivity>()
        .HasOne(ua => ua.Activity)
        .WithMany(a => a.UserActivities)
        .HasForeignKey(ua => ua.ActivityId);

    modelBuilder.Entity<UserActivity>()
        .HasOne(ua => ua.Itinerary)
        .WithMany(i => i.Activities)
        .HasForeignKey(ua => ua.ItineraryId);

            // Add other entity configurations...
        }

        // Add Fluent API configurations

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configure foreign key for ItineraryID
        //    modelBuilder.Entity<Booking>()
        //        .HasOne(b => b.Itinerary)
        //        .WithMany(i => i.Bookings)
        //        .HasForeignKey(b => b.Itinerary.ItineraryID)
        //        .OnDelete(DeleteBehavior.Restrict); // Restrict cascade

        //    // Configure foreign key for PaymentMethodPayment_Id
        //    modelBuilder.Entity<Booking>()
        //        .HasOne(b => b.PaymentMethod)
        //        .WithMany(p => p.Bookings)
        //        .HasForeignKey(b => b.PaymentMethod.Payment_Id)
        //        .OnDelete(DeleteBehavior.Restrict); // Restrict cascade

        //    // Configure foreign key for UserId
        //    modelBuilder.Entity<Booking>()
        //        .HasOne(b => b.User)
        //        .WithMany(u => u.Bookings)
        //        .HasForeignKey(b => b.User.UserId)
        //        .OnDelete(DeleteBehavior.Restrict); // Restrict cascade

        //    base.OnModelCreating(modelBuilder);
        //}


    }

}

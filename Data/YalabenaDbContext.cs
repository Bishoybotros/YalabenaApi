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
        public DbSet<Account> Accounts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);





            modelBuilder.Entity<User>()
                .HasMany(u => u.Itineraries)
                .WithOne(i => i.User)
                .HasForeignKey(i => i.UserId);





            modelBuilder.Entity<User>()
                .HasMany(u => u.Reviews) // A user has many reviews
                .WithOne(r => r.Users) // A review belongs to one user
                .HasForeignKey(u => u.UserId); // Specify the foreign key in the Review entity



            // One-to-Many: User -> Bookings
            modelBuilder.Entity<User>()
                .HasMany(u => u.Bookings)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.UserId)
                .IsRequired(false);

            // One-to-One: User -> Preference
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserPreferences)
                .WithOne(p => p.User)
                .HasForeignKey<Preference>(p => p.UserId)
                .IsRequired(false); // Optional relationship (if preferences aren't mandatory)

           

            // One-to-Many: User -> Activities
            modelBuilder.Entity<User>()
                .HasMany(u => u.Activities)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .IsRequired(false);


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

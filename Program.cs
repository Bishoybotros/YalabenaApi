using Microsoft.EntityFrameworkCore;
using YalabenaApi.Data;
using YalabenaApi.Hubs;

namespace YalabenaApi
{
    public class Program
    {
        // Add-Migration InitialCreate
        // Update-Database

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configure services and DBContext
            builder.Services.AddDbContext<YalabenaDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("YalabenaDb")));
            builder.Services.AddSignalR();
            builder.Services.AddHttpClient();

            // Add other necessary services to the container
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Connection string for legacy data migration and monitoring
            string connectionString = builder.Configuration.GetConnectionString("YalabenaDb");

            // Migrate legacy data
            var dataMigration = new DataMigration(connectionString);
            dataMigration.MigrateLegacyData();

            // Set up monitoring and optimization
            var monitoring = new MonitoringAndOptimization(connectionString);
            monitoring.MonitorPerformance();
            monitoring.OptimizeDatabase();

            // Configure the HTTP request pipeline
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();
            app.MapHub<NotificationHub>("/notificationhub");

            // Run the application
            app.Run();
        }
    }

    // Add DataMigration class for handling migration of legacy data
    public class DataMigration
    {
        private readonly string _connectionString;

        public DataMigration(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void MigrateLegacyData()
        {
            // Implement the logic to migrate legacy data here
            // Example:
            Console.WriteLine("Migrating legacy data...");
            // Migrate data from legacy systems or external sources
        }
    }

    // Add MonitoringAndOptimization class for performance monitoring and optimization
    public class MonitoringAndOptimization
    {
        private readonly string _connectionString;

        public MonitoringAndOptimization(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void MonitorPerformance()
        {
            // Implement performance monitoring logic here
            // Example: check query performance, slow queries, etc.
            Console.WriteLine("Monitoring database performance...");
        }

        public void OptimizeDatabase()
        {
            // Implement database optimization logic here
            // Example: apply indexing, cleanup tasks, etc.
            Console.WriteLine("Optimizing database...");
        }
    }
}

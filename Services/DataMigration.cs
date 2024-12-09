using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;

public class DataMigration
{
    private readonly string _connectionString;
    private IServiceCollection con;

    public DataMigration(string connectionString)
    {
        _connectionString = connectionString;
    }

    public DataMigration(IServiceCollection con)
    {
        this.con = con;
    }

    public void MigrateLegacyData()
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            // Example: Migrate data into the Users table
            string query = @"
                INSERT INTO Users (BishoyBotros, Bishoybotros, yalabena, CreatedAt)
                SELECT LegacyUserName, LegacyEmail, LegacyPasswordHash, GETDATE()
                FROM LegacyUsers";

            using (var command = new SqlCommand(query, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} rows migrated successfully.");
            }
        }
    }
}

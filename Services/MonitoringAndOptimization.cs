using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;

public class MonitoringAndOptimization
{
    private readonly string _connectionString;
    private IServiceCollection con;

    public MonitoringAndOptimization(string connectionString)
    {
        _connectionString = connectionString;
    }

    public MonitoringAndOptimization(IServiceCollection con)
    {
        this.con = con;
    }

    public void MonitorPerformance()
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            // Example: Check slow-running queries
            string query = @"
                SELECT TOP 5
                    qs.total_elapsed_time / qs.execution_count AS AvgExecutionTime,
                    qs.execution_count,
                    st.text AS QueryText
                FROM sys.dm_exec_query_stats qs
                CROSS APPLY sys.dm_exec_sql_text(qs.sql_handle) st
                ORDER BY AvgExecutionTime DESC";

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Query: {reader["QueryText"]}, AvgTime: {reader["AvgExecutionTime"]}");
                    }
                }
            }
        }
    }

    public void OptimizeDatabase()
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            // Example: Rebuild Indexes
            string query = @"
                EXEC sp_MSforeachtable 
                @command1 = 'ALTER INDEX ALL ON ? REBUILD';";

            using (var command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Indexes rebuilt successfully.");
            }
        }
    }
}

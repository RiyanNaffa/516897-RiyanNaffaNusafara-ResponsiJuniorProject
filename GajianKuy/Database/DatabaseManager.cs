using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace GajianKuy.Database
{
    public class DatabaseManager
    {
        private readonly string connectionString;

        public DatabaseManager(string connectionString)
        {
            if(string.IsNullOrWhiteSpace(connectionString)) throw new ArgumentNullException("Connection string cannot be null or empty", nameof(connectionString));
            connectionString = connectionString.Trim();
        }
        public (DataTable dt, string error) ExecuteQuery(string query, params NpgsqlParameter[] parameters)
        {
            if (string.IsNullOrWhiteSpace(query)) return (new DataTable(), "Query cannot be null or empty.");
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var da = new NpgsqlDataAdapter(cmd))
                {
                    if (parameters != null && parameters.Length > 0) cmd.Parameters.AddRange(parameters);

                    DataTable dt = new DataTable();
                    conn.Open();
                    da.Fill(dt);
                    return (dt, string.Empty);
                }
            }
            catch (NpgsqlException e)
            {
                return (new DataTable(), $"Database Error: {e.Message}");
            }
            catch (Exception e)
            {
                return (new DataTable(), $"Unexpected Error: {e.Message}");
            }
        }

        public void ExecuteNonQuery(string query, params NpgsqlParameter[] parameters)
        {
            if (string.IsNullOrWhiteSpace(query)) throw new ArgumentException("Query cannot be null or empty.", nameof(query);
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0) cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException e)
            {
                throw new Exception($"Database Error: {e.Message}", e);
            }
            catch (Exception e)
            {
                throw new Exception($"Unexpected Error: {e.Message}", e);
            }
        }
    }
}

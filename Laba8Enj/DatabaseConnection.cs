using Npgsql;
using System;

namespace Laba8Enj
{
    public class DatabaseConnection
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=postgres";

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
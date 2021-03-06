﻿using System.Configuration;
using System.Data.SqlClient;

namespace BulkWriter.Tests
{
    internal static class TestHelpers
    {
        public static void ExecuteNonQuery(string connectionString, string commandText)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(commandText, sqlConnection))
                {
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static string ConnectionString => ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
    }
}
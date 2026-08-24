using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Good_Reads_Prog_Project.functions
{
    public class dbRead
    {
        public static string ReadData(string query)
        {
            var config = new Config();
            string result = string.Empty;
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(config.DBAccessString))
            {
                try
                {
                    connection.Open();
                    using (var command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming you want to read the first column as a string
                                result += reader[0].ToString() + Environment.NewLine;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., log them)
                    result = "Error: " + ex.Message;
                }
            }
            return result;
        }
    }
}

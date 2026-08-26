using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Good_Reads_Prog_Project.functions
{
    public class dbRead
    {
        public static string ReadDB(string tableName, string idName, int id, string columnName)
        {
            Config config = new Config();
            string result = null;

            string sSQL = $"SELECT [{columnName}] FROM [{tableName}] WHERE [{idName}] = {id}";

            SqlConnection conn = new SqlConnection(config.DBAccessString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sSQL, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // return the first value as string (preserve null if DB has null)
                    if (reader[0] != DBNull.Value)
                    {
                        result = reader[0].ToString();
                    }
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception)
            {
                // swallow exceptions but return null so callers can detect failure
                result = null;
            }

            return result;
        }

        public static int dbIdMax(string tableName, string idName)
        {
            Config config = new Config();
            int maxId = 0;
            string result = "";

            string sSQL = $"SELECT MAX([{idName}]) FROM [{tableName}]";

            SqlConnection conn = new SqlConnection(config.DBAccessString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sSQL, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)
                    {
                        maxId = Convert.ToInt32(reader[0]);
                    }
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                result = "Error: " + ex.Message;
            }

            return maxId;
        }

        public static byte[] ReadImageBytesDB(string tableName, string idColumn, int idValue, string imageColumn)
        {
            byte[] imageData = null;
            var config = new Config();

            string connectionString = config.DBAccessString;

            string query = $"SELECT {imageColumn} FROM {tableName} WHERE {idColumn} = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", idValue);
                conn.Open();

                try
                {
                    object result = cmd.ExecuteScalar();

                    // Only accept results that are actually byte[]
                    if (result is byte[] bytes)
                    {
                        imageData = bytes;
                    }
                    else
                    {
                        // unexpected result type (null or non-bytes) -> return null
                        imageData = null;
                    }
                }
                catch (Exception)
                {
                    // on any DB error return null so caller can handle gracefully
                    imageData = null;
                }
            }

            return imageData;
        }
    }
}

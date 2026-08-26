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
            string result = "";

            string sSQL = $"SELECT [{columnName}] FROM [{tableName}] WHERE [{idName}] = {id}";

            SqlConnection conn = new SqlConnection(config.DBAccessString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sSQL, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result += reader[0].ToString() + Environment.NewLine;
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                result = "Error: " + ex.Message;
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
    }
}

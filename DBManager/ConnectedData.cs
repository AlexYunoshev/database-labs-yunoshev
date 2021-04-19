using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;

namespace DBManager
{
    public static class ConnectedData
    {

        static ConnectedData()
        {
            connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;Initial Catalog = yunoshevdb; Integrated Security = True;";
            connection.Open();
        }

        public static SqlConnection connection = new SqlConnection();
        public static SqlCommand command;
        public static SqlDataReader dataReader;

        private static int row = 0;
        private static int column = 0;

        public static string ServerName { get; set; }
        public static string DBName { get; set; }
        public static bool IntegratedSecurity { get; set; } = false;

        public static void SetCommand(string query)
        {
            command = new SqlCommand(query, connection);
        }

        public static int[] GetRowAndColumnCount()
        {
            dataReader = command.ExecuteReader();
            int row = 0;
            while (dataReader.Read())
            {
                row++;
            }
            int column = dataReader.FieldCount;
            dataReader.Close();
            int[] data = new int[2];
            data[0] = row;
            data[1] = column;
            ConnectedData.row = row;
            ConnectedData.column = column;
            return data;
        }

        public static bool CheckExist()
        {
            dataReader = command.ExecuteReader();
            string index = "-1";
            while (dataReader.Read())
            {
                if (dataReader[0].ToString() != "")
                    index = dataReader[0].ToString();
            }
            dataReader.Close();
            if (index != "-1")
                return true;
            else return false;
        }

        public static string[] GetRowFromTable()
        {
            int[] count = GetRowAndColumnCount();
            dataReader = command.ExecuteReader();
            string[] data = new string[count[1]];
            while (dataReader.Read())
            {
                for (int j = 0; j < column; j++)
                {
                    if (dataReader[j].ToString() != "")
                        data[j] = dataReader[j].ToString();
                    else
                        data[j] = "-";
                }
            }
            dataReader.Close();
            return data;
        }

        public static string[,] GetTableData()
        {
            dataReader = command.ExecuteReader();
            int i = 0;
            string[,] data = new string[row, column];
            while (dataReader.Read())
            {
                for (int j = 0; j < column; j++)
                {
                    if (dataReader[j].ToString() != "")
                        data[i, j] = dataReader[j].ToString();
                    else
                        data[i, j] = "-";
                }
                i++;
            }
            dataReader.Close();
            return data;
        }

        public static int UpdateData()
        {
            int count = command.ExecuteNonQuery();
            return count;
        }
    }
}

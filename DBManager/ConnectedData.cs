using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
        private static SqlCommand command;
        private static SqlDataReader dataReader;

        private static int row = 0;
        private static int column = 0;

        public static string ServerName { get; set; }
        public static string DBName { get; set; }
        public static bool IntegratedSecurity { get; set; } = false;



        public static void InitializeConnection()
        {
            connection.ConnectionString = @"Data Source = " + ServerName + ";"
            + "Initial Catalog = " + DBName + ";"
            + "Integrated Security=" + IntegratedSecurity + ";";
            connection.Open();
        }



        public static void SetCommand(string query)
        {
            command = new SqlCommand(query, connection);
        }

        public static int[] GetRowAndColumnCount()
        {
            dataReader = command.ExecuteReader();
            int r = 0;
            while(dataReader.Read())
            {
                r++;
            }
            int c = dataReader.FieldCount;
            dataReader.Close();
            int[] data = new int[2];
            data[0] = row;
            data[1] = column;
            row = r;
            column = c;
            return data;
        }


        public static string[,] GetTableData()
        {
            dataReader = command.ExecuteReader();
            int i = 0;
            string[,] data = new string[row, column];
            while(dataReader.Read())
            {
                for (int j = 0; j < column; j++)
                {
                    if(dataReader[j].ToString() != "")
                        data[i, j] = dataReader[j].ToString();
                    else
                        data[i, j] = "-";

                }
                i++;
            }
            dataReader.Close();
            return data;
        }

    }

}

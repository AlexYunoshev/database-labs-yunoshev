using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;
using System.Data;

namespace DBManager
{
    public static class DisconnectedData
    {
        static DisconnectedData()
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;Initial Catalog = yunoshevdb; Integrated Security = True;";
        }

        private static SqlConnection connection;
        private static SqlDataAdapter dataAdapter;
        private static SqlCommand sqlCommand;
        private static DataSet dataSet;


        public static DataSet GetTableData(string query)
        {
            dataSet = new DataSet();
            connection.Open();
            dataAdapter = new SqlDataAdapter(query, connection);
            dataAdapter.Fill(dataSet);
            connection.Close();
            return dataSet;
        }

        public static int InsertData(string query)
        {
            dataSet = new DataSet();
            connection.Open();
            dataAdapter = new SqlDataAdapter(query, connection);
            sqlCommand = new SqlCommand(query, connection);
            dataAdapter.InsertCommand = sqlCommand;
            int count = dataAdapter.InsertCommand.ExecuteNonQuery();
            connection.Close();
            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;

namespace DBManager
{
    public class ConnectedData
    {

        public ConnectedData(string ConnectionString)
        {
            connection.ConnectionString = ConnectionString;
            connection.Open();
        }

        public ConnectedData(string ServerName, string DBName)
        {
            this.ServerName = ServerName;
            this.DBName = DBName;
            connection.Open();
        }

        public ConnectedData(string ServerName, string DBName, bool IntegratedSecurity)
        {
            this.ServerName = ServerName;
            this.DBName = DBName;
            this.IntegratedSecurity = IntegratedSecurity;
            connection.Open();
        }

        private SqlConnection connection = new SqlConnection();
        private SqlCommand command;
        private SqlDataReader dataReader;

        private int row = 0;
        private int column = 0;

        public string ServerName { get; set; }
        public string DBName { get; set; }
        public bool IntegratedSecurity { get; set; } = false;



        public void InitializeConnection()
        {
            connection.ConnectionString = @"server=" + ServerName + ";"
            + "integrated security=" + IntegratedSecurity + ";"
            + "database=" + DBName + ";";
        }

        public void SetCommand(string query)
        {
            command = new SqlCommand(query, connection);
        }

        public int[] GetRowAndColumnCount()
        {
            dataReader = command.ExecuteReader();
            int row = 0;
            while(dataReader.Read())
            {
                row++;
            }
            int column = dataReader.FieldCount;
            dataReader.Close();
            int[] data = new int[2];
            data[0] = row;
            data[1] = column;
            this.row = row;
            this.column = column;
            return data;
        }

        public bool CheckExist(out int countOut)
        {
            int count = command.ExecuteNonQuery();
            countOut = count;
            if (count > 0) return true;
            else return false;
        }

        public string[,] GetTableData()
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

        public int UpdateData()
        {
            int count = command.ExecuteNonQuery();
            return count;
        }

    }

}

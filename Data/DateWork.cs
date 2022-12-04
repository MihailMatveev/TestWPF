using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows;

namespace TestWPF.Data
{
    public static class DateWork
    {
        static string  connectionString = "Server=(localdb)\\MSSQLLocalDB;Trusted_Connection=True;";
        static SqlConnection connection = new SqlConnection(connectionString);


        static void ConnectDate()
        {
            try
            {
                // Открываем подключение
                connection.Open();
                MessageBox.Show("Соединение открыто");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void Dispose()
        {
            if (connection.State == ConnectionState.Open)
            {
                // закрываем подключение
                connection.Close();
                MessageBox.Show("Соединение закрыто");
            }
        }

        static public string SearchBall(string result)
        {
            ConnectDate();

            string sqlExpression = $"SELECT Ball FROM [NFP].[dbo].[№4] WHERE Result={result}";

            SqlCommand command = new SqlCommand(sqlExpression, connection);
            string ball = Convert.ToString(command.ExecuteNonQuery());
            return ball;
        }
    }
}

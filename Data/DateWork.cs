using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows;
using TestWPF.Models;

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
            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[№4] WHERE Result={result}";

            SqlCommand command = new SqlCommand(sqlExpression, connection);

            string ball =Convert.ToString(command.ExecuteScalar());
            connection.Close();
            return ball;
        }


        static public string ForceSearchBall(string result, int selectNumberExercises)
        {
            ConnectDate();

            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[№{NameAndNumberExercisesbyqualities.ForceExercisesNameAndNumber[selectNumberExercises].Number}] WHERE Result='{result}'";

            SqlCommand command = new SqlCommand(sqlExpression, connection);

            string ball = Convert.ToString(command.ExecuteScalar());
            connection.Close();
            return ball;
        }


        static public string SpeedSearchBall(string result, int selectNumberExercises)
        {
            ConnectDate();
            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[№{NameAndNumberExercisesbyqualities.SpeedExercisesNameAndNumber[selectNumberExercises].Number}] WHERE Result='{result}'";

            SqlCommand command = new SqlCommand(sqlExpression, connection);

            string ball = Convert.ToString(command.ExecuteScalar());
            connection.Close();
            return ball;
        }

        static public string EnduranceSearchBall(string result, int selectNumberExercises)
        {
            ConnectDate();
            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[№{NameAndNumberExercisesbyqualities.EnduranceExercisesNameAndNumber[selectNumberExercises].Number}] WHERE Result='{result}'";

            SqlCommand command = new SqlCommand(sqlExpression, connection);

            string ball = Convert.ToString(command.ExecuteScalar());
            connection.Close();
            return ball;
        }

        static public List<Name_Exercises> SearchName_Exercises()
        {
            List<Name_Exercises> name_Exercises = new List<Name_Exercises>();

            ConnectDate();
            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[Name_Exercises] ";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    name_Exercises.Add(new Name_Exercises()
                    {
                        Name = reader.GetString("name"),
                        Number = reader.GetString("number")
                    });
                }
            }
            connection.Close();
                  
            return name_Exercises;
        }



        static public List<BallResultExercises> SearchBallExercises()
        {
            List<Name_Exercises> name_Exercises = SearchName_Exercises();
            List<BallResultExercises> ball_result = new List<BallResultExercises>();

            ConnectDate();
            foreach (var name in name_Exercises)
            {
                ball_result.Add(new BallResultExercises());
                string sqlExpression = $"SELECT * FROM [NFP].[dbo].[{name.Number.Trim()}] ";
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {

                }
               
                
            }
            }
           
            connection.Close();

            return ball_result;
        }





    }
}

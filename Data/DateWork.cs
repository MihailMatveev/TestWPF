using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Policy;
using System.Text;
using System.Windows;
using TestWPF.Infastructure.Base;
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
                   name_Exercises.Add( new Name_Exercises()
                    {
                        Number = reader.GetString("number"),
                        Name = reader.GetString("name")
                    });
                };
            }
            connection.Close();
                  
            return name_Exercises;
        }



        static public List<BallResultExercisesForce> SearchBallExercisesForce()
        {
            string nameExercises = "AllBallResultForce";
           
            List<BallResultExercisesForce> ball_result = new List<BallResultExercisesForce>();

            ConnectDate();
 
            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[{nameExercises}] ";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ball_result.Add(new BallResultExercisesForce()
                    {
                        Ball = reader.GetInt32("Ball"),
                        Result_1 = reader.GetString("Result_1"),
                        Result_2 = reader.GetString("Result_2"),
                        Result_4 = reader.GetString("Result_4"),
                        Result_5 = reader.GetString("Result_5"),
                        Result_6 = reader.GetString("Result_6"),
                        Result_7 = reader.GetString("Result_7"),
                        Result_8_1 = reader.GetString("Result_8_1"),
                        Result_8_2 = reader.GetString("Result_8_2"),
                        Result_9 = reader.GetString("Result_9"),
                        Result_10 = reader.GetString("Result_10"),
                        Result_11_1 = reader.GetString("Result_11_1"),
                        Result_11_2 = reader.GetString("Result_11_2"),
                        Result_12_1 = reader.GetString("Result_12_1"),
                        Result_12_2 = reader.GetString("Result_12_2"),
                        Result_13_1 = reader.GetString("Result_13_1"),
                        Result_13_2 = reader.GetString("Result_13_2"),
                    });
                };
            }

            connection.Close();
            ball_result.Reverse();
            return ball_result;
        }



        static public List<BallResultExercisesSpeed> SearchBallExercisesSpeed()
        {
            string nameExercises = "AllBallResultSpeed";


            List<BallResultExercisesSpeed> ball_result = new List<BallResultExercisesSpeed>();

            ConnectDate();

            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[{nameExercises}] ";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ball_result.Add(new BallResultExercisesSpeed()
                    {
                        Ball = reader.GetInt32("Ball"),
                        Result_40 = reader.GetString("Result_40"),
                        Result_41 = reader.GetString("Result_41"),
                        Result_42 = reader.GetString("Result_42"),
                        Result_43 = reader.GetString("Result_43"),
                        Result_44 = reader.GetString("Result_44"),         
                    });
                };
            }

            connection.Close();
            ball_result.Reverse();
            return ball_result;
        }

        static public List<BallResultExercisesEndurance> SearchBallExercisesEndurance()
        {
            string nameExercises = "AllBallResultEndurance";


            List<BallResultExercisesEndurance> ball_result = new List<BallResultExercisesEndurance>();

            ConnectDate();

            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[{nameExercises}] ";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ball_result.Add(new BallResultExercisesEndurance()
                    {
                        Ball = reader.GetInt32("Ball"),
                        Result_45_1 = reader.GetString("Result_45_1"),
                        Result_45_2 = reader.GetString("Result_45_2"),
                        Result_46_1 = reader.GetString("Result_46_1"),
                        Result_46_2 = reader.GetString("Result_46_2"),
                        Result_47 = reader.GetString("Result_47"),
                        Result_48 = reader.GetString("Result_48"),
                        Result_53 = reader.GetString("Result_53"),
                        Result_57_b = reader.GetString("Result_57_b"),
                    });
                };
            }

            connection.Close();
            ball_result.Reverse();
            return ball_result;
        }


        static public List<CategoryMillitary> SearchCategory()
        {
            List<CategoryMillitary> category = new List<CategoryMillitary>(); 

            ConnectDate();
            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[CategoryMillitary]";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    category.Add(new CategoryMillitary()
                    {
                        Number = reader.GetString("Number").Trim(),
                        Name = reader.GetString("Name").Replace("\r\n", string.Empty)
                });
                };
            }
            connection.Close();

            return category;
        }
    }
}

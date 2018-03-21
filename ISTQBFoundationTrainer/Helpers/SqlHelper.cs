using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ISTQBFoundationTrainer.Models;

namespace ISTQBFoundationTrainer.Helpers
{
    public static class SqlHelper
    {
        private static readonly string ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"{AppDomain.CurrentDomain.BaseDirectory}App_Data\\Database1.mdf\";Integrated Security=True";

        private static SqlConnection GetConnection() => new SqlConnection(ConnectionString);

        public static Question ReadQuestion(int questionId)
        {
            return ReadQuestion($"where Id = {questionId}");
        }

        public static Question ReadRandomQuestion()
        {
            return ReadQuestion("ORDER BY NEWID()");
        }

        private static Question ReadQuestion(string condition)
        {
            var conn = GetConnection();
            conn.Open();
            Question question = null;
            try
            {
                var command = conn.CreateCommand();
                command.CommandText = $"SELECT TOP(1) * FROM Questions {condition}";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    question = new Question
                    {
                        Id = reader.GetInt32(0),
                        EnglishText = reader.GetString(1),
                        RussianText = reader.IsDBNull(2) ? reader.GetString(1) : reader.GetString(2),
                        Resource = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Theme = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Answers = ReadAnswers(reader.GetInt32(0))
                    };
                }
            }
            catch (Exception)
            {
                Console.Write("Can not access database");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return question;
        }

        public static List<Answer> ReadAnswers(int questionId)
        {
            var conn = GetConnection();
            conn.Open();
            var command = conn.CreateCommand();
            command.CommandText = $"SELECT * FROM [Answers] WHERE QuestionId = '{questionId}'";
            var answers = new List<Answer>();
            try
            {
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    answers.Add(new Answer
                    {
                        Id = reader.GetInt32(0),
                        QuestionId = reader.GetInt32(1),
                        EnglishText = reader.GetString(2),
                        RussianText = reader.IsDBNull(3) ? reader.GetString(2) : reader.GetString(3),
                        IsCorrect = reader.GetBoolean(4)
                    });
                }
            }
            catch (Exception)
            {
                Console.Write("Can not access database");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return answers;
        }
    }
}
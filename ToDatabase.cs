using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationMark2
{
    internal class ToDatabase
    {
        Form1 connector;
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        ToDatabase controller;
        public ToDatabase(string ConnStr)
        {
            connection = new OleDbConnection(ConnStr);
            bufferTable = new DataTable();
        }
        //Данный метод предназнаен для добавления string`овых и byte[]`овых значений в БД
        public void Add(string Login, byte[] hash, byte[] salt)
        {
            connection.Open(); 
            var command = new OleDbCommand($"SELECT COUNT(*) FROM Users WHERE Login = @Login", connection);
            command.Parameters.AddWithValue("@Login", Login);
            int userCount = (int)command.ExecuteScalar();

            if (userCount == 0)
            {
                command = new OleDbCommand($"INSERT INTO Users (Login, Hash, Salt) VALUES(@Login, @Hash, @Salt)", connection);
                command.Parameters.AddWithValue("@Login", Login);
                command.Parameters.AddWithValue("@Hash", hash);
                command.Parameters.AddWithValue("@Salt", salt);
                command.ExecuteNonQuery();
                MessageBox.Show($"Данные добавленны,");
                //string readableHash = BitConverter.ToString(hash).Replace("-", "").ToLower();
                //MessageBox.Show($"{Login},{hash}, {salt}");
            }
            else
            {
                MessageBox.Show("Пользователь с таким именем уже существует");
            }
            connection.Close(); 
        }
        //Данный метод предназнаен для проверки и введённых пользователем Password
        public void Inspect(string Login, string Password)
        {
            connection.Open();
            var command = new OleDbCommand("SELECT Hash, Salt FROM Users WHERE Login = @Login", connection);
            command.Parameters.AddWithValue("@Login", Login);
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                byte[] hash = reader["Hash"] as byte[];
                byte[] salt = reader["Salt"] as byte[];

                MessageBox.Show($"{Login},  {hash},  {salt}", "Пользователь найден.");

                CodePass transfer = new CodePass();
                CodePass.VerifyHash(Password, hash, salt); //Передача в класс CodePass Password, hash, salt для последующего сравнения
            }
            else
            {
                MessageBox.Show("Пользователь не найден.");
            }
            connection.Close();
        }

    }
}

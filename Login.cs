using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RT
{
    public partial class Login : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UsersDB.accdb;";

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Reg af = new Reg();
            af.Owner = this;
            af.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;  // Пароль, введенный пользователем

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                label4.Text = "Заполните все поля!";
                return;
            }

            // Проверка в базе данных и получение роли
            string userRole = GetUserRole(username, password);

            if (userRole != null)
            {

                // Перенаправление на форму в зависимости от роли
                if (userRole == "admin")
                {
                    Form1 adminForm = new Form1();
                    adminForm.Show();
                }
                else
                {
                    Form2 userForm = new Form2();
                    userForm.Show();
                }

                this.Hide(); // Скрываем форму логина
            }
            else
            {
                label4.Text = "Неправильный логин или пароль";
            }
        }

        // Получение роли пользователя из базы данных + проверка пароля
        private string GetUserRole(string username, string password)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    Console.WriteLine("Попытка открытия соединения..."); // Отладочное сообщение
                    try
                    {
                        conn.Open();
                        Console.WriteLine("Соединение успешно открыто."); // Отладочное сообщение
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка открытия соединения: {ex.Message}");
                        MessageBox.Show($"Ошибка подключения к базе данных: {ex.ToString()}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    // Получаем пароль и роль из базы данных для данного пользователя
                    string query = "SELECT [Password], Role FROM Users WHERE Username = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string passwordFromDb = reader["Password"].ToString(); // Пароль из базы
                                string role = reader["Role"].ToString();        // Роль из базы

                                // Сравниваем введенный пароль с паролем из базы данных
                                if (password == passwordFromDb)
                                {
                                    // Пароль верен!
                                    Console.WriteLine("Пользователь успешно аутентифицирован.");  //Отладочное сообщение
                                    return role; // Возвращаем роль
                                }
                                else
                                {
                                    // Неправильный пароль
                                    Console.WriteLine("Неправильный пароль."); // Отладочное сообщение
                                    return null;
                                }
                            }
                            else
                            {
                                // Пользователь не найден
                                Console.WriteLine("Пользователь не найден."); // Отладочное сообщение
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при проверке пользователя: " + ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Общая ошибка в процессе аутентификации: {ex.ToString()}"); // Отладочное сообщение
                return null;
            }
        }

    }
}
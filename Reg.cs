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
    public partial class Reg : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=|DataDirectory|\UsersDB.accdb;";

        public Reg()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Регистрация пользователя";
            this.StartPosition = FormStartPosition.CenterScreen;
            lblMessage.ForeColor = Color.Blue;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Этот метод сейчас пустой, но если вам нужна какая-то логика для кнопки BtnRegister, добавьте её сюда
        }

        private void ShowMessage(string message, Color color)
        {
            lblMessage.Text = message;
            lblMessage.ForeColor = color;
        }

        private void ResetForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            // Этот метод сейчас пустой, но если вам нужна какая-то логика для кнопки btnRegister_Click_1, добавьте её сюда
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который должен выполняться при загрузке формы
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                ShowMessage("Введите имя пользователя!", Color.Red);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowMessage("Введите пароль!", Color.Red);
                return;
            }

            if (password.Length < 4)
            {
                ShowMessage("Пароль должен содержать минимум 4 символа!", Color.Red);
                return;
            }

            OleDbConnection conn = null; // Объявляем conn вне блока try
            try
            {
                conn = new OleDbConnection(connectionString);
                Console.WriteLine("Попытка открытия соединения..."); // Отладочное сообщение

                try
                {
                    conn.Open();
                    Console.WriteLine("Соединение успешно открыто."); // Отладочное сообщение
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка открытия соединения: {ex.Message}");
                    ShowMessage($"Ошибка подключения к базе данных: {ex.Message}", Color.Red);
                    MessageBox.Show($"Ошибка подключения к базе данных: {ex.ToString()}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверяем, существует ли пользователь с таким именем уже
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = ?";
                OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn); // Объявляем команды вне using
                checkCmd.Parameters.AddWithValue("@Username", username);
                int userCount = (int)checkCmd.ExecuteScalar();
                checkCmd.Dispose(); // Освобождаем ресурсы команды

                if (userCount > 0)
                {
                    ShowMessage("Пользователь с таким именем уже зарегистрирован!", Color.Red);
                    Console.WriteLine("Пользователь с таким именем уже существует."); // Отладочное сообщение
                    return; // Прерываем регистрацию
                }


                // SQL-запрос для вставки данных пользователя (с ролью)
                string insertQuery = "INSERT INTO Users (Username, [Password], Role) VALUES (?, ?, ?)";

                OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn); // Объявляем команды вне using
                                                                              // Добавляем параметры с защитой от SQL-инъекций
                insertCmd.Parameters.AddWithValue("@Username", username);
                insertCmd.Parameters.AddWithValue("@Password", password); // Сохраняем пароль в открытом виде (ОПАСНО!)
                insertCmd.Parameters.AddWithValue("@Role", "user"); // Роль пользователя ("user" по умолчанию)


                // Выполнение запроса
                int rowsAffected = insertCmd.ExecuteNonQuery();
                insertCmd.Dispose(); // Освобождаем ресурсы команды


                if (rowsAffected > 0)
                {
                    ShowMessage("Регистрация успешна!", Color.Green);
                    Console.WriteLine("Регистрация прошла успешно."); // Отладочное сообщение
                    ResetForm();
                }
                else
                {
                    ShowMessage("Ошибка при регистрации!", Color.Red);
                    Console.WriteLine("Ошибка при регистрации."); // Отладочное сообщение
                }

            }
            catch (Exception ex)
            {
                ShowMessage("Ошибка: " + ex.Message, Color.Red);
                MessageBox.Show($"Полная ошибка:\n{ex.ToString()}", "Детали ошибки",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Общая ошибка в процессе регистрации: {ex.ToString()}"); // Отладочное сообщение
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close(); // Закрываем соединение в блоке finally
                    conn.Dispose(); // Освобождаем ресурсы соединения
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}
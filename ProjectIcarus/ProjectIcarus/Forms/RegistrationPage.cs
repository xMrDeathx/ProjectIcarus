using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjectIcarus.Classes;
using ProjectIcarus.Database;
using ProjectIcarus.Forms;

namespace ProjectIcarus
{
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();

            this.passwordTextBox.AutoSize = false;
            this.passwordTextBox.Size = new Size(this.passwordTextBox.Width, this.eMailTextBox.Height);

            usernameTextBox.Text = "Имя пользователя";
            usernameTextBox.ForeColor = Color.Gray;

            eMailTextBox.Text = "Электронный адрес";
            eMailTextBox.ForeColor = Color.Gray;

            passwordTextBox.Text = "Пароль";
            passwordTextBox.ForeColor = Color.Gray;

            repeatPasswordTextBox.Text = "Подтвердите пароль";
            repeatPasswordTextBox.ForeColor = Color.Gray;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void background_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void background_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }
        private void AppNameLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }
        private void AppNameLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Имя пользователя")
            {
                usernameTextBox.Text = string.Empty;
                usernameTextBox.ForeColor = Color.White;
            }
        }
        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == string.Empty)
            {
                usernameTextBox.Text = "Имя пользователя";
                usernameTextBox.ForeColor = Color.Gray;
            }
        }
        private void eMailTextBox_Enter(object sender, EventArgs e)
        {
            if (eMailTextBox.Text == "Электронный адрес")
            {
                eMailTextBox.Text = string.Empty;
                eMailTextBox.ForeColor = Color.White;
            }
        }
        private void eMailTextBox_Leave(object sender, EventArgs e)
        {
            if (eMailTextBox.Text == string.Empty)
            {
                eMailTextBox.Text = "Электронный адрес";
                eMailTextBox.ForeColor = Color.Gray;
            }
        }
        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Пароль")
            {
                passwordTextBox.Text = string.Empty;
                passwordTextBox.ForeColor = Color.White;
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == string.Empty)
            {
                passwordTextBox.Text = "Пароль";
                passwordTextBox.ForeColor = Color.Gray;
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }
        private void repeatPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (repeatPasswordTextBox.Text == "Подтвердите пароль")
            {
                repeatPasswordTextBox.Text = string.Empty;
                repeatPasswordTextBox.ForeColor = Color.White;
                repeatPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
        private void repeatPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (repeatPasswordTextBox.Text == string.Empty)
            {
                repeatPasswordTextBox.Text = "Подтвердите пароль";
                repeatPasswordTextBox.ForeColor = Color.Gray;
                repeatPasswordTextBox.UseSystemPasswordChar = false;
            }
        }
        private void backToAuthorization_Click(object sender, EventArgs e)
        {
            AuthorizationPage authorizationPage= new AuthorizationPage();
            authorizationPage.StartPosition= FormStartPosition.Manual;
            authorizationPage.SetDesktopLocation(this.Left, this.Top);
            this.Hide();
            authorizationPage.Show();
        }
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != string.Empty && eMailTextBox.Text != string.Empty
                && passwordTextBox.Text != string.Empty && repeatPasswordTextBox.Text != string.Empty)
            {
                if (passwordTextBox.Text == repeatPasswordTextBox.Text)
                {
                    string username = usernameTextBox.Text;
                    string login = eMailTextBox.Text;
                    string password = passwordTextBox.Text;

                    DBWork db = new DBWork();
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand getUsersCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @l", db.getConnection());
                    getUsersCommand.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;

                    adapter.SelectCommand = getUsersCommand;
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        MySqlCommand createNewUserCommand = new MySqlCommand("INSERT INTO `users` (`username`, `login`, `password`) VALUES (@u, @l, @p)", db.getConnection());
                        createNewUserCommand.Parameters.Add("@u", MySqlDbType.VarChar).Value = username;
                        createNewUserCommand.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
                        createNewUserCommand.Parameters.Add("@p", MySqlDbType.VarChar).Value = password;

                        db.openConnection();

                        if (createNewUserCommand.ExecuteNonQuery() == 1)
                        {
                            int id;
                            MySqlDataReader reader;
                            reader = getUsersCommand.ExecuteReader();
                            reader.Read();
                            id = reader.GetInt32(0);
                            CurrentUser currentUser = CurrentUser.Initialize();
                            currentUser.ID = id;
                            db.closeConnection();
                            MainPage mainPage = new MainPage();
                            mainPage.SetDesktopLocation(this.Left, this.Top);
                            this.Hide();
                            mainPage.Show();
                        }
                        else
                        {
                            db.closeConnection();
                            MessageBox.Show("Неизвестная ошибка!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: \n Пользователь с такой электронной почтой уже существует!");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка: \n Пароли не совпадают!");
                }
            }
            else
            {
                MessageBox.Show("Ошибка: \n Все поля должны быть заполнены!");
            }
        }
    }
}
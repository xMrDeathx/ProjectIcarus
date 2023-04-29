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
    public partial class AuthorizationPage : Form
    {
        public AuthorizationPage()
        {
            InitializeComponent();

            eMailTextBox.Text = "Электронный адрес";
            eMailTextBox.ForeColor = Color.Gray;

            this.passwordTextBox.AutoSize = false;
            this.passwordTextBox.Size = new Size(this.passwordTextBox.Width, this.eMailTextBox.Height);

            passwordTextBox.Text = "Пароль";
            passwordTextBox.ForeColor = Color.Gray;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void background_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
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
                passwordTextBox.UseSystemPasswordChar = false;
                passwordTextBox.ForeColor = Color.Gray;
                passwordTextBox.Text = "Пароль";
            }
        }
        private void goToRegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationPage registrationPage= new RegistrationPage();
            registrationPage.SetDesktopLocation(this.Left, this.Top);
            registrationPage.Show();
        }
        private void enterButton_Click(object sender, EventArgs e)
        {
            string login = eMailTextBox.Text;
            string password = passwordTextBox.Text;

            DBWork db = new DBWork();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @l AND `password` = @p", db.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = password;

            db.openConnection();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                int id;
                MySqlDataReader reader;
                reader = command.ExecuteReader();
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
                MessageBox.Show("Ошибка: \n Неверный логин или пароль!");
            }
        }
    }
}

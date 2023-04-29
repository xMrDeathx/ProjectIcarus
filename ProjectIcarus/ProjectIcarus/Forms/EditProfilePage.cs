using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjectIcarus.Classes;
using ProjectIcarus.Database;

namespace ProjectIcarus.Forms
{
    public partial class EditProfilePage : Form
    {
        public EditProfilePage()
        {
            InitializeComponent();
        }

        public string usernameChangerTxtBox
        {
            get { return UserNameChangerTextBox.Text; }
            set { UserNameChangerTextBox.Text = value; }
        }

        public string descriptionChangerTxtBox
        {
            get { return DescriptionEditorRichTextBox.Text; }
            set { DescriptionEditorRichTextBox.Text = value; }
        }

        OpenFileDialog openImage = new OpenFileDialog();

        /*
        private void backgroundChanger_Click(object sender, EventArgs e)
        {
            openImage.ShowDialog();// открываем окно
            string FileName = openImage.FileName;// берем полный адрес картинки            
            currentBackgroundPictureBox.ImageLocation = FileName;// грузим картинку в pictureBox
        }

        private void currentBackgroundPictureBox_Click(object sender, EventArgs e)
        {
            openImage.ShowDialog();// открываем окно
            string FileName = openImage.FileName;// берем полный адрес картинки            
            currentBackgroundPictureBox.ImageLocation = FileName;// грузим картинку в pictureBox
        }
        */

        private void saveChangesLabel_Click(object sender, EventArgs e)
        {
            CurrentUser currentUser = CurrentUser.Initialize();
            DBWork db = new DBWork();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand updateUserInfo = new MySqlCommand("UPDATE `users` SET `username` = @un, `profiledescription` = @pd WHERE `id` = @id", db.getConnection());
            updateUserInfo.Parameters.Add("@id", MySqlDbType.Int32).Value = currentUser.ID;
            updateUserInfo.Parameters.Add("@un", MySqlDbType.VarChar).Value = UserNameChangerTextBox.Text;
            updateUserInfo.Parameters.Add("@pd", MySqlDbType.Text).Value = DescriptionEditorRichTextBox.Text;

            db.openConnection();

            if (updateUserInfo.ExecuteNonQuery() == 1)
            {
                MySqlCommand getUserCommand = new MySqlCommand("SELECT `username`, `profiledescription` FROM `users` WHERE `id` = @i", db.getConnection());
                getUserCommand.Parameters.Add("@i", MySqlDbType.Int64).Value = currentUser.ID;

                MySqlDataReader reader;
                reader = getUserCommand.ExecuteReader();
                reader.Read();

                UserProfilePage profilePage = new UserProfilePage();
                profilePage.StartPosition = FormStartPosition.Manual;
                profilePage.SetDesktopLocation(this.Left, this.Top);
                profilePage.usernameTxtBox = reader.GetString(0);
                profilePage.descriptionTxtBox = reader.GetString(1);
                db.closeConnection();
                this.Hide();
                profilePage.Show();
            }
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
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToProfile_Click(object sender, EventArgs e)
        {
            CurrentUser currentUser = CurrentUser.Initialize();
            DBWork db = new DBWork();
            MySqlCommand getUserCommand = new MySqlCommand("SELECT `username`, `profiledescription` FROM `users` WHERE `id` = @i", db.getConnection());
            getUserCommand.Parameters.Add("@i", MySqlDbType.Int64).Value = currentUser.ID;
            db.openConnection();
            MySqlDataReader reader;
            reader = getUserCommand.ExecuteReader();
            reader.Read();
            UserProfilePage profilePage = new UserProfilePage();
            profilePage.StartPosition = FormStartPosition.Manual;
            profilePage.SetDesktopLocation(this.Left, this.Top);
            profilePage.usernameTxtBox = reader.GetString(0);
            profilePage.descriptionTxtBox = reader.GetString(1);
            db.closeConnection();
            this.Hide();
            profilePage.Show();
        }
    }
}

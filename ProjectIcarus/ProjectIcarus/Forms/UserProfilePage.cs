using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjectIcarus.Classes;
using ProjectIcarus.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectIcarus.Forms
{
    public partial class UserProfilePage : Form
    {
        public UserProfilePage()
        {
            InitializeComponent();

            CurrentUser currentUser = CurrentUser.Initialize();
            notCurrentUser notCurrentUser = notCurrentUser.Initialize();

            if (currentUser.ID == notCurrentUser.ID)
            {
                this.editProfileButton.Enabled = true;
                this.editProfileButton.Show();

                this.followButtonLabel.Enabled = false;
                this.followButtonLabel.Hide();

                this.unfollowButtonLabel.Enabled = false;
                this.unfollowButtonLabel.Hide();
            }
            else
            {
                this.editProfileButton.Enabled = false;
                this.editProfileButton.Hide();

                DBWork db = new DBWork();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `followings` WHERE `followeduserid` = @fd AND `followeruserid` = @fr", db.getConnection());
                command.Parameters.Add("@fd", MySqlDbType.VarChar).Value = notCurrentUser.ID;
                command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = currentUser.ID;

                db.openConnection();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    this.followButtonLabel.Enabled = false;
                    this.followButtonLabel.Hide();

                    this.unfollowButtonLabel.Tag = table.Rows[0][0];
                    this.unfollowButtonLabel.Enabled = true;
                    this.unfollowButtonLabel.Show();
                }
                else
                {
                    this.followButtonLabel.Enabled = true;
                    this.followButtonLabel.Show();

                    this.unfollowButtonLabel.Enabled = false;
                    this.unfollowButtonLabel.Hide();
                }
            }
        }

        public string usernameTxtBox
        {
            get { return usernameLabel.Text; }
            set { usernameLabel.Text = value; }
        }

        public string descriptionTxtBox
        { 
            get { return ProfileDescriptionTextBox.Text; }
            set { ProfileDescriptionTextBox.Text = value;}
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

        private void followButtonLabel_Click(object sender, EventArgs e)
        {
            CurrentUser currentUser = CurrentUser.Initialize();
            notCurrentUser notCurrentUser = notCurrentUser.Initialize();
            DBWork db = new DBWork();
            MySqlCommand createNewFollowng = new MySqlCommand("INSERT INTO `followings` (`followeduserid`, `followeruserid`) VALUES ((SELECT `id` FROM `users` WHERE `id` = @fd), (SELECT `id` FROM `users` WHERE `id` = @fr))", db.getConnection());
            createNewFollowng.Parameters.Add("@fd", MySqlDbType.Int32).Value = notCurrentUser.ID;
            createNewFollowng.Parameters.Add("@fr", MySqlDbType.Int32).Value = currentUser.ID;

            db.openConnection();

            if (createNewFollowng.ExecuteNonQuery() == 1)
            {
                MySqlCommand getFollowingID = new MySqlCommand("SELECT `id` FROM `followings` WHERE `followeduserid` = @fd AND `followeruserid` = @fr", db.getConnection());
                getFollowingID.Parameters.Add("@fd", MySqlDbType.UInt32).Value = notCurrentUser.ID;
                getFollowingID.Parameters.Add("@fr", MySqlDbType.UInt32).Value = currentUser.ID;
                MySqlDataReader reader;
                reader = getFollowingID.ExecuteReader();
                reader.Read();
                unfollowButtonLabel.Tag = reader.GetInt32(0);
                followButtonLabel.Hide();
                followButtonLabel.Enabled = false;
                unfollowButtonLabel.Location = followButtonLabel.Location;
                unfollowButtonLabel.Show();
                unfollowButtonLabel.Enabled = true;
                db.closeConnection();
            }
            else
            {
                db.closeConnection();
                MessageBox.Show("Неизвестная ошибка!");
            }
        }

        private void unfollowButtonLabel_Click(object sender, EventArgs e)
        {
            CurrentUser currentUser = CurrentUser.Initialize();
            notCurrentUser notCurrentUser = notCurrentUser.Initialize();
            DBWork db = new DBWork();
            MySqlCommand deleteFollowng = new MySqlCommand("DELETE FROM `followings` WHERE `id` = @fid", db.getConnection());
            deleteFollowng.Parameters.Add("@fid", MySqlDbType.Int32).Value = unfollowButtonLabel.Tag;

            db.openConnection();
            if (deleteFollowng.ExecuteNonQuery() == 1)
            {
                unfollowButtonLabel.Hide();
                unfollowButtonLabel.Enabled = false;
                followButtonLabel.Location = unfollowButtonLabel.Location;
                followButtonLabel.Show();
                followButtonLabel.Enabled = true;
                db.closeConnection();
            }
            else
            {
                db.closeConnection();
                MessageBox.Show("Неизвестная ошибка!");
            }
        }

        private void backToMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.StartPosition = FormStartPosition.Manual;
            mainPage.SetDesktopLocation(this.Left, this.Top);
            this.Hide();
            mainPage.Show();
        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            EditProfilePage editProfilePage = new EditProfilePage();
            editProfilePage.usernameChangerTxtBox = usernameLabel.Text;
            editProfilePage.descriptionChangerTxtBox = ProfileDescriptionTextBox.Text;
            editProfilePage.StartPosition = FormStartPosition.Manual;
            editProfilePage.SetDesktopLocation(this.Left, this.Top);
            this.Hide();
            editProfilePage.Show();
        }
    }
}
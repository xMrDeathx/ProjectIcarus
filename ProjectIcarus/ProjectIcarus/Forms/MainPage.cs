using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectIcarus.Classes;
using ProjectIcarus.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml;

namespace ProjectIcarus.Forms
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        struct listElement
        {
            public User user;
            public System.Windows.Forms.Panel userLayoutPanel;
            public System.Windows.Forms.Label userLayoutLabel;
            public System.Windows.Forms.PictureBox profilePictureBox;
        }

        private listElement CreateListElement(int count, MySqlDataReader reader)
        {
            listElement tmpElement = new listElement();
            tmpElement.user = new User();
            tmpElement.user.id = reader.GetInt32(0);
            tmpElement.user.userName = reader.GetString(1);
            tmpElement.userLayoutPanel = new System.Windows.Forms.Panel();
            tmpElement.userLayoutPanel.Name = "UserLayoutPanel" + count;
            tmpElement.userLayoutPanel.Size = new System.Drawing.Size(545, 50);
            tmpElement.userLayoutPanel.Cursor = System.Windows.Forms.Cursors.Hand;

            tmpElement.userLayoutLabel = new System.Windows.Forms.Label();
            tmpElement.userLayoutLabel.Dock = System.Windows.Forms.DockStyle.Right;
            tmpElement.userLayoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tmpElement.userLayoutLabel.ForeColor = System.Drawing.Color.White;
            tmpElement.userLayoutLabel.Name = "userLayoutLabel" + count;
            tmpElement.userLayoutLabel.Size = new System.Drawing.Size(480, 50);
            tmpElement.userLayoutLabel.Text = tmpElement.user.userName;
            tmpElement.userLayoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tmpElement.userLayoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;

            tmpElement.profilePictureBox = new System.Windows.Forms.PictureBox();
            tmpElement.profilePictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            tmpElement.profilePictureBox.Name = "ProfilePictureBox" + count;
            tmpElement.profilePictureBox.Size = new System.Drawing.Size(50, 50);
            tmpElement.profilePictureBox.TabStop = false;
            tmpElement.profilePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;

            tmpElement.userLayoutPanel.Tag = count;
            tmpElement.userLayoutLabel.Tag = count;
            tmpElement.profilePictureBox.Tag = count;

            tmpElement.userLayoutPanel.Click += new System.EventHandler(openUserProfile);
            tmpElement.userLayoutLabel.Click += new System.EventHandler(openUserProfile);
            tmpElement.profilePictureBox.Click += new System.EventHandler(openUserProfile);

            tmpElement.userLayoutPanel.Controls.Add(tmpElement.userLayoutLabel);
            tmpElement.userLayoutPanel.Controls.Add(tmpElement.profilePictureBox);

            return tmpElement;
        }
        List<listElement> listElements = new List<listElement>();
        private void MainPage_Load(object sender, EventArgs e)
        {
            DBWork db = new DBWork();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand getUsersCommand = new MySqlCommand("SELECT `id`, `username` FROM `users`", db.getConnection());

            db.openConnection();

            MySqlDataReader reader;
            reader = getUsersCommand.ExecuteReader();
            int count = 0;
            while(reader.Read())
            {
                count++;
                listElement element;
                element = CreateListElement(count, reader);

                listElements.Add(element);
                this.usersFlowLayoutPanel.Controls.Add(element.userLayoutPanel);
            }
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
        private void openUserProfile(object sender, EventArgs e)
        {
            int index = (int)(sender as Control).Tag;
            CurrentUser currentUser = CurrentUser.Initialize();
            notCurrentUser notCurrentUser = notCurrentUser.Initialize();

            DBWork db = new DBWork();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand getUserCommand = new MySqlCommand("SELECT `id`, `username`, `profiledescription` FROM `users` WHERE `id` = @i", db.getConnection());
            getUserCommand.Parameters.Add("@i", MySqlDbType.Int64).Value = listElements[index - 1].user.id;

            db.openConnection();

            MySqlDataReader reader;
            reader = getUserCommand.ExecuteReader();
            reader.Read();

            notCurrentUser.ID = reader.GetInt32(0);

            UserProfilePage profilePage = new UserProfilePage();
            profilePage.StartPosition = FormStartPosition.Manual;
            profilePage.SetDesktopLocation(this.Left, this.Top);
            profilePage.usernameTxtBox = reader.GetString(1);
            profilePage.descriptionTxtBox = reader.GetString(2);
            db.closeConnection();
            this.Hide();
            profilePage.Show();
        }

        private void toCurrentUserProfileButtonLabel_Click(object sender, EventArgs e)
        {
            CurrentUser currentUser = CurrentUser.Initialize();
            notCurrentUser notCurrentUser = notCurrentUser.Initialize();
            notCurrentUser.ID = currentUser.ID;

            DBWork db = new DBWork();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand getUsersCommand = new MySqlCommand("SELECT `username`, `profiledescription` FROM `users` WHERE `id` = @i", db.getConnection());
            getUsersCommand.Parameters.Add("@i", MySqlDbType.Int64).Value = currentUser.ID;

            db.openConnection();

            MySqlDataReader reader;
            reader = getUsersCommand.ExecuteReader();
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
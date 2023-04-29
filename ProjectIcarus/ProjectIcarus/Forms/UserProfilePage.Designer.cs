namespace ProjectIcarus.Forms
{
    partial class UserProfilePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.background = new System.Windows.Forms.Panel();
            this.unfollowButtonLabel = new System.Windows.Forms.Label();
            this.followButtonLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.articlesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddNewPostButton = new System.Windows.Forms.Label();
            this.ProfileDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.followersSplitContainer = new System.Windows.Forms.SplitContainer();
            this.userFollowersLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editProfileButton = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.backToMainPage = new System.Windows.Forms.Label();
            this.background.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.followersSplitContainer)).BeginInit();
            this.followersSplitContainer.Panel1.SuspendLayout();
            this.followersSplitContainer.Panel2.SuspendLayout();
            this.followersSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.SteelBlue;
            this.background.BackgroundImage = global::ProjectIcarus.Properties.Resources.defaultBackgroundImage;
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Controls.Add(this.unfollowButtonLabel);
            this.background.Controls.Add(this.followButtonLabel);
            this.background.Controls.Add(this.groupBox1);
            this.background.Controls.Add(this.ProfileDescriptionTextBox);
            this.background.Controls.Add(this.followersSplitContainer);
            this.background.Controls.Add(this.editProfileButton);
            this.background.Controls.Add(this.usernameLabel);
            this.background.Controls.Add(this.profilePictureBox);
            this.background.Controls.Add(this.CloseButton);
            this.background.Controls.Add(this.backToMainPage);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(588, 471);
            this.background.TabIndex = 2;
            this.background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.background_MouseDown);
            this.background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.background_MouseMove);
            // 
            // unfollowButtonLabel
            // 
            this.unfollowButtonLabel.AutoSize = true;
            this.unfollowButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.unfollowButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unfollowButtonLabel.ForeColor = System.Drawing.Color.White;
            this.unfollowButtonLabel.Location = new System.Drawing.Point(247, 111);
            this.unfollowButtonLabel.Name = "unfollowButtonLabel";
            this.unfollowButtonLabel.Size = new System.Drawing.Size(197, 31);
            this.unfollowButtonLabel.TabIndex = 19;
            this.unfollowButtonLabel.Text = "Вы подписаны";
            this.unfollowButtonLabel.Click += new System.EventHandler(this.unfollowButtonLabel_Click);
            // 
            // followButtonLabel
            // 
            this.followButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.followButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.followButtonLabel.ForeColor = System.Drawing.Color.White;
            this.followButtonLabel.Location = new System.Drawing.Point(234, 85);
            this.followButtonLabel.Name = "followButtonLabel";
            this.followButtonLabel.Size = new System.Drawing.Size(200, 35);
            this.followButtonLabel.TabIndex = 18;
            this.followButtonLabel.Text = "Подписаться";
            this.followButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.followButtonLabel.Click += new System.EventHandler(this.followButtonLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.articlesFlowLayoutPanel);
            this.groupBox1.Controls.Add(this.AddNewPostButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 137);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // articlesFlowLayoutPanel
            // 
            this.articlesFlowLayoutPanel.AutoScroll = true;
            this.articlesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.articlesFlowLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.articlesFlowLayoutPanel.Name = "articlesFlowLayoutPanel";
            this.articlesFlowLayoutPanel.Size = new System.Drawing.Size(431, 118);
            this.articlesFlowLayoutPanel.TabIndex = 14;
            this.articlesFlowLayoutPanel.WrapContents = false;
            // 
            // AddNewPostButton
            // 
            this.AddNewPostButton.AutoSize = true;
            this.AddNewPostButton.BackColor = System.Drawing.Color.Transparent;
            this.AddNewPostButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddNewPostButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddNewPostButton.Font = new System.Drawing.Font("Wingdings 2", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.AddNewPostButton.Location = new System.Drawing.Point(440, 16);
            this.AddNewPostButton.Name = "AddNewPostButton";
            this.AddNewPostButton.Size = new System.Drawing.Size(145, 115);
            this.AddNewPostButton.TabIndex = 16;
            this.AddNewPostButton.Text = "И";
            // 
            // ProfileDescriptionTextBox
            // 
            this.ProfileDescriptionTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProfileDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfileDescriptionTextBox.Location = new System.Drawing.Point(0, 240);
            this.ProfileDescriptionTextBox.Name = "ProfileDescriptionTextBox";
            this.ProfileDescriptionTextBox.ReadOnly = true;
            this.ProfileDescriptionTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ProfileDescriptionTextBox.Size = new System.Drawing.Size(588, 96);
            this.ProfileDescriptionTextBox.TabIndex = 15;
            this.ProfileDescriptionTextBox.Text = "";
            // 
            // followersSplitContainer
            // 
            this.followersSplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.followersSplitContainer.IsSplitterFixed = true;
            this.followersSplitContainer.Location = new System.Drawing.Point(0, 194);
            this.followersSplitContainer.Name = "followersSplitContainer";
            // 
            // followersSplitContainer.Panel1
            // 
            this.followersSplitContainer.Panel1.Controls.Add(this.userFollowersLabel);
            this.followersSplitContainer.Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // followersSplitContainer.Panel2
            // 
            this.followersSplitContainer.Panel2.Controls.Add(this.label3);
            this.followersSplitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.followersSplitContainer.Size = new System.Drawing.Size(588, 45);
            this.followersSplitContainer.SplitterDistance = 289;
            this.followersSplitContainer.SplitterWidth = 10;
            this.followersSplitContainer.TabIndex = 13;
            // 
            // userFollowersLabel
            // 
            this.userFollowersLabel.AutoSize = true;
            this.userFollowersLabel.BackColor = System.Drawing.Color.Transparent;
            this.userFollowersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userFollowersLabel.ForeColor = System.Drawing.Color.White;
            this.userFollowersLabel.Location = new System.Drawing.Point(83, 11);
            this.userFollowersLabel.Name = "userFollowersLabel";
            this.userFollowersLabel.Size = new System.Drawing.Size(119, 24);
            this.userFollowersLabel.TabIndex = 0;
            this.userFollowersLabel.Text = "Подписчики";
            this.userFollowersLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(86, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Подписки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // editProfileButton
            // 
            this.editProfileButton.AutoSize = true;
            this.editProfileButton.BackColor = System.Drawing.Color.Transparent;
            this.editProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editProfileButton.ForeColor = System.Drawing.Color.White;
            this.editProfileButton.Location = new System.Drawing.Point(230, 40);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(322, 31);
            this.editProfileButton.TabIndex = 12;
            this.editProfileButton.Text = "Редактировать профиль";
            this.editProfileButton.Click += new System.EventHandler(this.editProfileButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(47, 141);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(139, 31);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "userName";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox.Image = global::ProjectIcarus.Properties.Resources.userImage;
            this.profilePictureBox.Location = new System.Drawing.Point(52, 40);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(80, 80);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 10;
            this.profilePictureBox.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Webdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(548, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 30);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "r";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // backToMainPage
            // 
            this.backToMainPage.AutoSize = true;
            this.backToMainPage.BackColor = System.Drawing.Color.Transparent;
            this.backToMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToMainPage.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.backToMainPage.ForeColor = System.Drawing.Color.White;
            this.backToMainPage.Location = new System.Drawing.Point(-5, 0);
            this.backToMainPage.Name = "backToMainPage";
            this.backToMainPage.Size = new System.Drawing.Size(38, 26);
            this.backToMainPage.TabIndex = 9;
            this.backToMainPage.Text = "з";
            this.backToMainPage.Click += new System.EventHandler(this.backToMainPage_Click);
            // 
            // UserProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 471);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfilePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UserProfilePage";
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.followersSplitContainer.Panel1.ResumeLayout(false);
            this.followersSplitContainer.Panel1.PerformLayout();
            this.followersSplitContainer.Panel2.ResumeLayout(false);
            this.followersSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.followersSplitContainer)).EndInit();
            this.followersSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Label backToMainPage;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label editProfileButton;
        private System.Windows.Forms.SplitContainer followersSplitContainer;
        private System.Windows.Forms.Label userFollowersLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ProfileDescriptionTextBox;
        private System.Windows.Forms.FlowLayoutPanel articlesFlowLayoutPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label AddNewPostButton;
        private System.Windows.Forms.Label followButtonLabel;
        private System.Windows.Forms.Label unfollowButtonLabel;
    }
}
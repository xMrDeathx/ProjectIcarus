namespace ProjectIcarus.Forms
{
    partial class MainPage
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
            this.toCurrentUserProfileButtonLabel = new System.Windows.Forms.Label();
            this.NewUsersLabel = new System.Windows.Forms.Label();
            this.usersFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.SteelBlue;
            this.background.BackgroundImage = global::ProjectIcarus.Properties.Resources.defaultBackgroundImage;
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Controls.Add(this.toCurrentUserProfileButtonLabel);
            this.background.Controls.Add(this.NewUsersLabel);
            this.background.Controls.Add(this.usersFlowLayoutPanel);
            this.background.Controls.Add(this.WarningLabel);
            this.background.Controls.Add(this.CloseButton);
            this.background.Controls.Add(this.AppNameLabel);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(572, 432);
            this.background.TabIndex = 4;
            this.background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.background_MouseDown);
            this.background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.background_MouseMove);
            // 
            // toCurrentUserProfileButtonLabel
            // 
            this.toCurrentUserProfileButtonLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.toCurrentUserProfileButtonLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toCurrentUserProfileButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toCurrentUserProfileButtonLabel.ForeColor = System.Drawing.Color.White;
            this.toCurrentUserProfileButtonLabel.Location = new System.Drawing.Point(216, 207);
            this.toCurrentUserProfileButtonLabel.Name = "toCurrentUserProfileButtonLabel";
            this.toCurrentUserProfileButtonLabel.Size = new System.Drawing.Size(142, 46);
            this.toCurrentUserProfileButtonLabel.TabIndex = 14;
            this.toCurrentUserProfileButtonLabel.Text = "Профиль пользователя";
            this.toCurrentUserProfileButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toCurrentUserProfileButtonLabel.Click += new System.EventHandler(this.toCurrentUserProfileButtonLabel_Click);
            // 
            // NewUsersLabel
            // 
            this.NewUsersLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewUsersLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewUsersLabel.ForeColor = System.Drawing.Color.White;
            this.NewUsersLabel.Location = new System.Drawing.Point(0, 266);
            this.NewUsersLabel.Name = "NewUsersLabel";
            this.NewUsersLabel.Size = new System.Drawing.Size(572, 41);
            this.NewUsersLabel.TabIndex = 12;
            this.NewUsersLabel.Text = "Новые пользователи";
            this.NewUsersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usersFlowLayoutPanel
            // 
            this.usersFlowLayoutPanel.AutoScroll = true;
            this.usersFlowLayoutPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.usersFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usersFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.usersFlowLayoutPanel.Location = new System.Drawing.Point(0, 307);
            this.usersFlowLayoutPanel.Name = "usersFlowLayoutPanel";
            this.usersFlowLayoutPanel.Size = new System.Drawing.Size(572, 125);
            this.usersFlowLayoutPanel.TabIndex = 11;
            this.usersFlowLayoutPanel.WrapContents = false;
            // 
            // WarningLabel
            // 
            this.WarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarningLabel.ForeColor = System.Drawing.Color.White;
            this.WarningLabel.Location = new System.Drawing.Point(87, 83);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(406, 101);
            this.WarningLabel.TabIndex = 10;
            this.WarningLabel.Text = "В БУДУЩЕМ ЗДЕСЬ БУДЕТ ГОРАЗДО БОЛЬШЕ ФУНКЦИЙ!";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Webdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(532, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 30);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "r";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.AppNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppNameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.AppNameLabel.Location = new System.Drawing.Point(0, 0);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(572, 73);
            this.AppNameLabel.TabIndex = 13;
            this.AppNameLabel.Text = "Project: ICARUS";
            this.AppNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 432);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.FlowLayoutPanel usersFlowLayoutPanel;
        private System.Windows.Forms.Label NewUsersLabel;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Label toCurrentUserProfileButtonLabel;
    }
}
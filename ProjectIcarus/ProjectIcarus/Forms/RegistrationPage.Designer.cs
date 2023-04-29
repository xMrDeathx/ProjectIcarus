namespace ProjectIcarus
{
    partial class RegistrationPage
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
            this.backToAuthorization = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationLabel = new System.Windows.Forms.Label();
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
            this.background.Controls.Add(this.backToAuthorization);
            this.background.Controls.Add(this.usernameTextBox);
            this.background.Controls.Add(this.repeatPasswordTextBox);
            this.background.Controls.Add(this.createAccountButton);
            this.background.Controls.Add(this.passwordTextBox);
            this.background.Controls.Add(this.eMailTextBox);
            this.background.Controls.Add(this.RegistrationLabel);
            this.background.Controls.Add(this.CloseButton);
            this.background.Controls.Add(this.AppNameLabel);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(604, 510);
            this.background.TabIndex = 1;
            this.background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.background_MouseDown);
            this.background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.background_MouseMove);
            // 
            // backToAuthorization
            // 
            this.backToAuthorization.AutoSize = true;
            this.backToAuthorization.BackColor = System.Drawing.Color.Transparent;
            this.backToAuthorization.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.backToAuthorization.ForeColor = System.Drawing.Color.White;
            this.backToAuthorization.Location = new System.Drawing.Point(-5, 0);
            this.backToAuthorization.Name = "backToAuthorization";
            this.backToAuthorization.Size = new System.Drawing.Size(38, 26);
            this.backToAuthorization.TabIndex = 9;
            this.backToAuthorization.Text = "з";
            this.backToAuthorization.Click += new System.EventHandler(this.backToAuthorization_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(75, 132);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(453, 55);
            this.usernameTextBox.TabIndex = 8;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.repeatPasswordTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.repeatPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repeatPasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(75, 369);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(453, 43);
            this.repeatPasswordTextBox.TabIndex = 7;
            this.repeatPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.repeatPasswordTextBox.Enter += new System.EventHandler(this.repeatPasswordTextBox_Enter);
            this.repeatPasswordTextBox.Leave += new System.EventHandler(this.repeatPasswordTextBox_Leave);
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.createAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountButton.FlatAppearance.BorderSize = 0;
            this.createAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAccountButton.ForeColor = System.Drawing.Color.Transparent;
            this.createAccountButton.Location = new System.Drawing.Point(151, 435);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(302, 50);
            this.createAccountButton.TabIndex = 6;
            this.createAccountButton.Text = "Создать аккаунт";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(75, 296);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(453, 43);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eMailTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.eMailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eMailTextBox.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eMailTextBox.ForeColor = System.Drawing.Color.White;
            this.eMailTextBox.Location = new System.Drawing.Point(75, 215);
            this.eMailTextBox.Multiline = true;
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(453, 55);
            this.eMailTextBox.TabIndex = 3;
            this.eMailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eMailTextBox.Enter += new System.EventHandler(this.eMailTextBox_Enter);
            this.eMailTextBox.Leave += new System.EventHandler(this.eMailTextBox_Leave);
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegistrationLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.ForeColor = System.Drawing.Color.Transparent;
            this.RegistrationLabel.Location = new System.Drawing.Point(0, 73);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(604, 56);
            this.RegistrationLabel.TabIndex = 2;
            this.RegistrationLabel.Text = "Регистрация";
            this.RegistrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Webdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(564, 0);
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
            this.AppNameLabel.Size = new System.Drawing.Size(604, 73);
            this.AppNameLabel.TabIndex = 0;
            this.AppNameLabel.Text = "Project: ICARUS";
            this.AppNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppNameLabel_MouseDown);
            this.AppNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AppNameLabel_MouseMove);
            // 
            // RegistrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 510);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RegistrationPage";
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label backToAuthorization;
    }
}
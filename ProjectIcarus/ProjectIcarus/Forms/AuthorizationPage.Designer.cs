namespace ProjectIcarus
{
    partial class AuthorizationPage
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
            this.orLabel = new System.Windows.Forms.Label();
            this.goToRegistrationButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.EnterLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Cyan;
            this.background.BackgroundImage = global::ProjectIcarus.Properties.Resources.defaultBackgroundImage;
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Controls.Add(this.orLabel);
            this.background.Controls.Add(this.goToRegistrationButton);
            this.background.Controls.Add(this.enterButton);
            this.background.Controls.Add(this.passwordTextBox);
            this.background.Controls.Add(this.eMailTextBox);
            this.background.Controls.Add(this.EnterLabel);
            this.background.Controls.Add(this.CloseButton);
            this.background.Controls.Add(this.AppNameLabel);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(604, 510);
            this.background.TabIndex = 0;
            this.background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.background_MouseDown);
            this.background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.background_MouseMove);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.BackColor = System.Drawing.Color.Transparent;
            this.orLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orLabel.ForeColor = System.Drawing.Color.White;
            this.orLabel.Location = new System.Drawing.Point(272, 393);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(60, 34);
            this.orLabel.TabIndex = 7;
            this.orLabel.Text = "Или";
            this.orLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goToRegistrationButton
            // 
            this.goToRegistrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.goToRegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToRegistrationButton.FlatAppearance.BorderSize = 0;
            this.goToRegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToRegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToRegistrationButton.ForeColor = System.Drawing.Color.Transparent;
            this.goToRegistrationButton.Location = new System.Drawing.Point(151, 448);
            this.goToRegistrationButton.Name = "goToRegistrationButton";
            this.goToRegistrationButton.Size = new System.Drawing.Size(302, 50);
            this.goToRegistrationButton.TabIndex = 6;
            this.goToRegistrationButton.Text = "Создать аккаунт";
            this.goToRegistrationButton.UseVisualStyleBackColor = false;
            this.goToRegistrationButton.Click += new System.EventHandler(this.goToRegistrationButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.Color.Transparent;
            this.enterButton.Location = new System.Drawing.Point(151, 321);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(302, 50);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(75, 228);
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
            this.eMailTextBox.Location = new System.Drawing.Point(75, 141);
            this.eMailTextBox.Multiline = true;
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(453, 55);
            this.eMailTextBox.TabIndex = 3;
            this.eMailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eMailTextBox.Enter += new System.EventHandler(this.eMailTextBox_Enter);
            this.eMailTextBox.Leave += new System.EventHandler(this.eMailTextBox_Leave);
            // 
            // EnterLabel
            // 
            this.EnterLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnterLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnterLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterLabel.ForeColor = System.Drawing.Color.Transparent;
            this.EnterLabel.Location = new System.Drawing.Point(0, 73);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(604, 56);
            this.EnterLabel.TabIndex = 2;
            this.EnterLabel.Text = "Войти";
            this.EnterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Webdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
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
            // AuthorizationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(604, 510);
            this.Controls.Add(this.background);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizationPage";
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.Label EnterLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button goToRegistrationButton;
        private System.Windows.Forms.Label orLabel;
    }
}
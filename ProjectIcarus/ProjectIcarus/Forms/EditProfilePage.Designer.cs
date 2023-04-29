namespace ProjectIcarus.Forms
{
    partial class EditProfilePage
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
            this.saveChangesLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DescriptionEditorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.backgroundChangePanel = new System.Windows.Forms.Panel();
            this.currentBackgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundChanger = new System.Windows.Forms.Label();
            this.UserNameChangerTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.backToProfile = new System.Windows.Forms.Label();
            this.openBackgroundImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.descriptionFontDialog = new System.Windows.Forms.FontDialog();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.backgroundChangePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentBackgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.SteelBlue;
            this.background.BackgroundImage = global::ProjectIcarus.Properties.Resources.defaultBackgroundImage;
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Controls.Add(this.saveChangesLabel);
            this.background.Controls.Add(this.pictureBox1);
            this.background.Controls.Add(this.DescriptionEditorRichTextBox);
            this.background.Controls.Add(this.backgroundChangePanel);
            this.background.Controls.Add(this.UserNameChangerTextBox);
            this.background.Controls.Add(this.CloseButton);
            this.background.Controls.Add(this.backToProfile);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(588, 471);
            this.background.TabIndex = 3;
            this.background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.background_MouseDown);
            this.background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.background_MouseMove);
            // 
            // saveChangesLabel
            // 
            this.saveChangesLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.saveChangesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChangesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChangesLabel.ForeColor = System.Drawing.Color.Black;
            this.saveChangesLabel.Location = new System.Drawing.Point(204, 372);
            this.saveChangesLabel.Name = "saveChangesLabel";
            this.saveChangesLabel.Size = new System.Drawing.Size(180, 50);
            this.saveChangesLabel.TabIndex = 17;
            this.saveChangesLabel.Text = "Сохранить изменения";
            this.saveChangesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveChangesLabel.Click += new System.EventHandler(this.saveChangesLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(244, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // DescriptionEditorRichTextBox
            // 
            this.DescriptionEditorRichTextBox.Location = new System.Drawing.Point(118, 254);
            this.DescriptionEditorRichTextBox.Name = "DescriptionEditorRichTextBox";
            this.DescriptionEditorRichTextBox.Size = new System.Drawing.Size(352, 96);
            this.DescriptionEditorRichTextBox.TabIndex = 15;
            this.DescriptionEditorRichTextBox.Text = "";
            // 
            // backgroundChangePanel
            // 
            this.backgroundChangePanel.BackColor = System.Drawing.Color.Transparent;
            this.backgroundChangePanel.Controls.Add(this.currentBackgroundPictureBox);
            this.backgroundChangePanel.Controls.Add(this.backgroundChanger);
            this.backgroundChangePanel.Location = new System.Drawing.Point(118, 202);
            this.backgroundChangePanel.Name = "backgroundChangePanel";
            this.backgroundChangePanel.Size = new System.Drawing.Size(352, 46);
            this.backgroundChangePanel.TabIndex = 14;
            // 
            // currentBackgroundPictureBox
            // 
            this.currentBackgroundPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.currentBackgroundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentBackgroundPictureBox.Location = new System.Drawing.Point(311, 3);
            this.currentBackgroundPictureBox.Name = "currentBackgroundPictureBox";
            this.currentBackgroundPictureBox.Size = new System.Drawing.Size(38, 38);
            this.currentBackgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentBackgroundPictureBox.TabIndex = 11;
            this.currentBackgroundPictureBox.TabStop = false;
            // 
            // backgroundChanger
            // 
            this.backgroundChanger.BackColor = System.Drawing.Color.Transparent;
            this.backgroundChanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backgroundChanger.ForeColor = System.Drawing.Color.White;
            this.backgroundChanger.Location = new System.Drawing.Point(9, 3);
            this.backgroundChanger.Name = "backgroundChanger";
            this.backgroundChanger.Size = new System.Drawing.Size(296, 38);
            this.backgroundChanger.TabIndex = 12;
            this.backgroundChanger.Text = "Фон";
            this.backgroundChanger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserNameChangerTextBox
            // 
            this.UserNameChangerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameChangerTextBox.Location = new System.Drawing.Point(118, 158);
            this.UserNameChangerTextBox.Name = "UserNameChangerTextBox";
            this.UserNameChangerTextBox.Size = new System.Drawing.Size(352, 38);
            this.UserNameChangerTextBox.TabIndex = 10;
            this.UserNameChangerTextBox.Text = "userName";
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
            // backToProfile
            // 
            this.backToProfile.AutoSize = true;
            this.backToProfile.BackColor = System.Drawing.Color.Transparent;
            this.backToProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToProfile.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.backToProfile.ForeColor = System.Drawing.Color.White;
            this.backToProfile.Location = new System.Drawing.Point(-5, 0);
            this.backToProfile.Name = "backToProfile";
            this.backToProfile.Size = new System.Drawing.Size(38, 26);
            this.backToProfile.TabIndex = 9;
            this.backToProfile.Text = "з";
            this.backToProfile.Click += new System.EventHandler(this.backToProfile_Click);
            // 
            // openBackgroundImageFileDialog
            // 
            this.openBackgroundImageFileDialog.FileName = "openFileDialog1";
            // 
            // EditProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 471);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProfilePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EditProfilePage";
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.backgroundChangePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentBackgroundPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label backToProfile;
        private System.Windows.Forms.TextBox UserNameChangerTextBox;
        private System.Windows.Forms.OpenFileDialog openBackgroundImageFileDialog;
        private System.Windows.Forms.Panel backgroundChangePanel;
        private System.Windows.Forms.PictureBox currentBackgroundPictureBox;
        private System.Windows.Forms.Label backgroundChanger;
        private System.Windows.Forms.FontDialog descriptionFontDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label saveChangesLabel;
        private System.Windows.Forms.RichTextBox DescriptionEditorRichTextBox;
    }
}
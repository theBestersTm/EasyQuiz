namespace EasyQuiz
{
    partial class Form1
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSubSettings = new System.Windows.Forms.Panel();
            this.Languages = new System.Windows.Forms.Button();
            this.AboutProgram = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.panelProfSubMenu = new System.Windows.Forms.Panel();
            this.DownloadFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.File = new System.Windows.Forms.Button();
            this.panelProfileSubmenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelSubSettings.SuspendLayout();
            this.panelProfSubMenu.SuspendLayout();
            this.panelProfileSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.panelSubSettings);
            this.panelSideMenu.Controls.Add(this.Settings);
            this.panelSideMenu.Controls.Add(this.panelProfSubMenu);
            this.panelSideMenu.Controls.Add(this.File);
            this.panelSideMenu.Controls.Add(this.panelProfileSubmenu);
            this.panelSideMenu.Controls.Add(this.Profile);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelSubSettings
            // 
            this.panelSubSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubSettings.Controls.Add(this.Languages);
            this.panelSubSettings.Controls.Add(this.AboutProgram);
            this.panelSubSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubSettings.Location = new System.Drawing.Point(0, 403);
            this.panelSubSettings.Name = "panelSubSettings";
            this.panelSubSettings.Size = new System.Drawing.Size(250, 89);
            this.panelSubSettings.TabIndex = 7;
            // 
            // Languages
            // 
            this.Languages.Dock = System.Windows.Forms.DockStyle.Top;
            this.Languages.FlatAppearance.BorderSize = 0;
            this.Languages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Languages.ForeColor = System.Drawing.Color.LightGray;
            this.Languages.Location = new System.Drawing.Point(0, 40);
            this.Languages.Name = "Languages";
            this.Languages.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Languages.Size = new System.Drawing.Size(250, 40);
            this.Languages.TabIndex = 3;
            this.Languages.Text = "Мовні налаштування";
            this.Languages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Languages.UseVisualStyleBackColor = true;
            this.Languages.Click += new System.EventHandler(this.Languages_Click);
            // 
            // AboutProgram
            // 
            this.AboutProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutProgram.FlatAppearance.BorderSize = 0;
            this.AboutProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutProgram.ForeColor = System.Drawing.Color.LightGray;
            this.AboutProgram.Location = new System.Drawing.Point(0, 0);
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.AboutProgram.Size = new System.Drawing.Size(250, 40);
            this.AboutProgram.TabIndex = 2;
            this.AboutProgram.Text = "Про програму";
            this.AboutProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutProgram.UseVisualStyleBackColor = true;
            this.AboutProgram.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // Settings
            // 
            this.Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.ForeColor = System.Drawing.Color.Gainsboro;
            this.Settings.Location = new System.Drawing.Point(0, 358);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Settings.Size = new System.Drawing.Size(250, 45);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "Налаштування";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // panelProfSubMenu
            // 
            this.panelProfSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelProfSubMenu.Controls.Add(this.DownloadFile);
            this.panelProfSubMenu.Controls.Add(this.SaveFile);
            this.panelProfSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfSubMenu.Location = new System.Drawing.Point(0, 273);
            this.panelProfSubMenu.Name = "panelProfSubMenu";
            this.panelProfSubMenu.Size = new System.Drawing.Size(250, 85);
            this.panelProfSubMenu.TabIndex = 5;
            // 
            // DownloadFile
            // 
            this.DownloadFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.DownloadFile.FlatAppearance.BorderSize = 0;
            this.DownloadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadFile.ForeColor = System.Drawing.Color.LightGray;
            this.DownloadFile.Location = new System.Drawing.Point(0, 40);
            this.DownloadFile.Name = "DownloadFile";
            this.DownloadFile.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.DownloadFile.Size = new System.Drawing.Size(250, 40);
            this.DownloadFile.TabIndex = 2;
            this.DownloadFile.Text = "Завантажити файл";
            this.DownloadFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DownloadFile.UseVisualStyleBackColor = true;
            this.DownloadFile.Click += new System.EventHandler(this.DownloadFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveFile.FlatAppearance.BorderSize = 0;
            this.SaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFile.ForeColor = System.Drawing.Color.LightGray;
            this.SaveFile.Location = new System.Drawing.Point(0, 0);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.SaveFile.Size = new System.Drawing.Size(250, 40);
            this.SaveFile.TabIndex = 1;
            this.SaveFile.Text = "Зберегти";
            this.SaveFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // File
            // 
            this.File.Dock = System.Windows.Forms.DockStyle.Top;
            this.File.FlatAppearance.BorderSize = 0;
            this.File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.File.ForeColor = System.Drawing.Color.Gainsboro;
            this.File.Location = new System.Drawing.Point(0, 228);
            this.File.Name = "File";
            this.File.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.File.Size = new System.Drawing.Size(250, 45);
            this.File.TabIndex = 4;
            this.File.Text = "Файл";
            this.File.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.File.UseVisualStyleBackColor = true;
            this.File.Click += new System.EventHandler(this.File_Click);
            // 
            // panelProfileSubmenu
            // 
            this.panelProfileSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelProfileSubmenu.Controls.Add(this.button2);
            this.panelProfileSubmenu.Controls.Add(this.Login);
            this.panelProfileSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfileSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelProfileSubmenu.Name = "panelProfileSubmenu";
            this.panelProfileSubmenu.Size = new System.Drawing.Size(250, 83);
            this.panelProfileSubmenu.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 40);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Зареєструватись";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.ForeColor = System.Drawing.Color.LightGray;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Login.Size = new System.Drawing.Size(250, 40);
            this.Login.TabIndex = 0;
            this.Login.Text = "Ввійти";
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click_1);
            // 
            // Profile
            // 
            this.Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profile.FlatAppearance.BorderSize = 0;
            this.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile.ForeColor = System.Drawing.Color.Gainsboro;
            this.Profile.Location = new System.Drawing.Point(0, 100);
            this.Profile.Name = "Profile";
            this.Profile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Profile.Size = new System.Drawing.Size(250, 45);
            this.Profile.TabIndex = 1;
            this.Profile.Text = "Профіль";
            this.Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::EasyQuiz.Properties.Resources.milky_way_2695569_1920;
            this.pictureBox1.Location = new System.Drawing.Point(170, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 213);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 561);
            this.panelChildForm.TabIndex = 1;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubSettings.ResumeLayout(false);
            this.panelProfSubMenu.ResumeLayout(false);
            this.panelProfileSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelProfileSubmenu;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelProfSubMenu;
        private System.Windows.Forms.Button DownloadFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button File;
        private System.Windows.Forms.Panel panelSubSettings;
        private System.Windows.Forms.Button Languages;
        private System.Windows.Forms.Button AboutProgram;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChildForm;
    }
}


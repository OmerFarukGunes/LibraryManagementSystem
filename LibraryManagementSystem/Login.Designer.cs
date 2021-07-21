
namespace LibraryManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.PBWebLink = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Show = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBWebLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(59, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(59, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 1);
            this.panel2.TabIndex = 4;
            this.panel2.TabStop = true;
            // 
            // TBUserName
            // 
            this.TBUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TBUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBUserName.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.TBUserName.ForeColor = System.Drawing.Color.White;
            this.TBUserName.Location = new System.Drawing.Point(59, 254);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(275, 14);
            this.TBUserName.TabIndex = 5;
            this.TBUserName.Text = "Kullanıcı Adı";
            this.TBUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TBUserName_MouseClick);
            this.TBUserName.TextChanged += new System.EventHandler(this.TBUserName_TextChanged);
            this.TBUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPassword.ForeColor = System.Drawing.Color.White;
            this.TBPassword.Location = new System.Drawing.Point(59, 310);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(275, 14);
            this.TBPassword.TabIndex = 6;
            this.TBPassword.Text = "Şifre";
            this.TBPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TBPassword_MouseClick);
            this.TBPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogin.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.Location = new System.Drawing.Point(250, 374);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(84, 30);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // PBWebLink
            // 
            this.PBWebLink.Image = ((System.Drawing.Image)(resources.GetObject("PBWebLink.Image")));
            this.PBWebLink.Location = new System.Drawing.Point(155, 45);
            this.PBWebLink.Name = "PBWebLink";
            this.PBWebLink.Size = new System.Drawing.Size(97, 95);
            this.PBWebLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBWebLink.TabIndex = 9;
            this.PBWebLink.TabStop = false;
            this.PBWebLink.Click += new System.EventHandler(this.PBWebLink_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.ForeColor = System.Drawing.Color.Red;
            this.BtnClose.Location = new System.Drawing.Point(353, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(31, 28);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Show
            // 
            this.Show.Image = ((System.Drawing.Image)(resources.GetObject("Show.Image")));
            this.Show.Location = new System.Drawing.Point(340, 304);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(27, 27);
            this.Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Show.TabIndex = 12;
            this.Show.TabStop = false;
            this.Show.MouseLeave += new System.EventHandler(this.Show_MouseLeave);
            this.Show.MouseHover += new System.EventHandler(this.Show_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(396, 599);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.PBWebLink);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUserName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.PBWebLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox PBWebLink;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Show;
    }
}


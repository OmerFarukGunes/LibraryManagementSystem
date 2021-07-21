
namespace LibraryManagementSystem
{
    partial class AddAuthorized
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthorized));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.LblAddStudent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBLibraries = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBAuthorizeType = new System.Windows.Forms.ComboBox();
            this.LblBookName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.Location = new System.Drawing.Point(314, 207);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 15;
            this.BtnReset.Text = "Sıfırla";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8F);
            this.label2.Location = new System.Drawing.Point(129, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "*Kişi öğrenci ise öğrenci numarası girilmek zorundadır.";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Location = new System.Drawing.Point(233, 207);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBPassword.Location = new System.Drawing.Point(111, 83);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(278, 24);
            this.TBPassword.TabIndex = 11;
            this.TBPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPassword.Location = new System.Drawing.Point(67, 88);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(38, 19);
            this.LblPassword.TabIndex = 10;
            this.LblPassword.Text = "Şifre";
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBEmail.Location = new System.Drawing.Point(111, 53);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(278, 24);
            this.TBEmail.TabIndex = 9;
            this.TBEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblAddStudent
            // 
            this.LblAddStudent.AutoSize = true;
            this.LblAddStudent.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAddStudent.Location = new System.Drawing.Point(94, 33);
            this.LblAddStudent.Name = "LblAddStudent";
            this.LblAddStudent.Size = new System.Drawing.Size(110, 24);
            this.LblAddStudent.TabIndex = 1;
            this.LblAddStudent.Text = "Çalışan Ekle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.LblAddStudent);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 85);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPrice.Location = new System.Drawing.Point(60, 58);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(45, 19);
            this.LblPrice.TabIndex = 8;
            this.LblPrice.Text = "Email";
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBName.Location = new System.Drawing.Point(111, 23);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(278, 24);
            this.TBName.TabIndex = 1;
            this.TBName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(16, 28);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(89, 19);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Kullanıcı Adı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.CBLibraries);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CBAuthorizeType);
            this.panel2.Controls.Add(this.LblBookName);
            this.panel2.Controls.Add(this.BtnReset);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.TBPassword);
            this.panel2.Controls.Add(this.LblPassword);
            this.panel2.Controls.Add(this.TBEmail);
            this.panel2.Controls.Add(this.LblPrice);
            this.panel2.Controls.Add(this.TBName);
            this.panel2.Controls.Add(this.LblName);
            this.panel2.Location = new System.Drawing.Point(258, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 323);
            this.panel2.TabIndex = 8;
            // 
            // CBLibraries
            // 
            this.CBLibraries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLibraries.Font = new System.Drawing.Font("Calibri", 10F);
            this.CBLibraries.FormattingEnabled = true;
            this.CBLibraries.Location = new System.Drawing.Point(111, 142);
            this.CBLibraries.Name = "CBLibraries";
            this.CBLibraries.Size = new System.Drawing.Size(278, 23);
            this.CBLibraries.TabIndex = 13;
            this.CBLibraries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kütüphane";
            // 
            // CBAuthorizeType
            // 
            this.CBAuthorizeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAuthorizeType.Font = new System.Drawing.Font("Calibri", 10F);
            this.CBAuthorizeType.FormattingEnabled = true;
            this.CBAuthorizeType.Location = new System.Drawing.Point(111, 113);
            this.CBAuthorizeType.Name = "CBAuthorizeType";
            this.CBAuthorizeType.Size = new System.Drawing.Size(278, 23);
            this.CBAuthorizeType.TabIndex = 12;
            this.CBAuthorizeType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBookName.Location = new System.Drawing.Point(65, 117);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(40, 19);
            this.LblBookName.TabIndex = 28;
            this.LblBookName.Text = "Yetki";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // AddAuthorized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(684, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddAuthorized";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Ekle";
            this.Load += new System.EventHandler(this.AddAuthorized_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label LblAddStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBAuthorizeType;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.ComboBox CBLibraries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
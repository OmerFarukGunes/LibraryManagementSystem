
namespace LibraryManagementSystem
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBStudentNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.LblStock = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TBTC = new System.Windows.Forms.TextBox();
            this.LblTC = new System.Windows.Forms.Label();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblAddStudent = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.BtnReset);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TBStudentNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.TBPhone);
            this.panel2.Controls.Add(this.LblStock);
            this.panel2.Controls.Add(this.TBEmail);
            this.panel2.Controls.Add(this.LblPrice);
            this.panel2.Controls.Add(this.TBTC);
            this.panel2.Controls.Add(this.LblTC);
            this.panel2.Controls.Add(this.TBSurname);
            this.panel2.Controls.Add(this.LblSurname);
            this.panel2.Controls.Add(this.TBName);
            this.panel2.Controls.Add(this.LblName);
            this.panel2.Location = new System.Drawing.Point(258, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 323);
            this.panel2.TabIndex = 5;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.Location = new System.Drawing.Point(314, 207);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 22;
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
            // TBStudentNo
            // 
            this.TBStudentNo.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBStudentNo.Location = new System.Drawing.Point(111, 167);
            this.TBStudentNo.Name = "TBStudentNo";
            this.TBStudentNo.Size = new System.Drawing.Size(278, 24);
            this.TBStudentNo.TabIndex = 6;
            this.TBStudentNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Öğrenci No*";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Location = new System.Drawing.Point(233, 207);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TBPhone
            // 
            this.TBPhone.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBPhone.Location = new System.Drawing.Point(111, 137);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(278, 24);
            this.TBPhone.TabIndex = 5;
            this.TBPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStock.Location = new System.Drawing.Point(48, 142);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(57, 19);
            this.LblStock.TabIndex = 10;
            this.LblStock.Text = "Telefon";
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBEmail.Location = new System.Drawing.Point(111, 107);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(278, 24);
            this.TBEmail.TabIndex = 4;
            this.TBEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPrice.Location = new System.Drawing.Point(60, 112);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(45, 19);
            this.LblPrice.TabIndex = 8;
            this.LblPrice.Text = "Email";
            // 
            // TBTC
            // 
            this.TBTC.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBTC.Location = new System.Drawing.Point(111, 77);
            this.TBTC.Name = "TBTC";
            this.TBTC.Size = new System.Drawing.Size(278, 24);
            this.TBTC.TabIndex = 3;
            this.TBTC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTC.Location = new System.Drawing.Point(14, 82);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(91, 19);
            this.LblTC.TabIndex = 4;
            this.LblTC.Text = "TC Kimlik No";
            // 
            // TBSurname
            // 
            this.TBSurname.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBSurname.Location = new System.Drawing.Point(111, 50);
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new System.Drawing.Size(278, 24);
            this.TBSurname.TabIndex = 2;
            this.TBSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSurname.Location = new System.Drawing.Point(58, 55);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(47, 19);
            this.LblSurname.TabIndex = 2;
            this.LblSurname.Text = "Soyad";
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
            this.LblName.Location = new System.Drawing.Point(79, 28);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(26, 19);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Ad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.LblAddStudent);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 85);
            this.panel1.TabIndex = 4;
            // 
            // LblAddStudent
            // 
            this.LblAddStudent.AutoSize = true;
            this.LblAddStudent.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAddStudent.Location = new System.Drawing.Point(94, 33);
            this.LblAddStudent.Name = "LblAddStudent";
            this.LblAddStudent.Size = new System.Drawing.Size(82, 24);
            this.LblAddStudent.TabIndex = 1;
            this.LblAddStudent.Text = "Üye Ekle";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(684, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Ekle";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TBTC;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.TextBox TBSurname;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblAddStudent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBStudentNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}
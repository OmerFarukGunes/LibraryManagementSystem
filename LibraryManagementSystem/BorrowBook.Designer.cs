
namespace LibraryManagementSystem
{
    partial class BorrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBook));
            this.LblAddStudent = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBStudentNo = new System.Windows.Forms.TextBox();
            this.LblStudentNo = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.LblPhone = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.LblTC = new System.Windows.Forms.Label();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CBBookName = new System.Windows.Forms.ComboBox();
            this.LblBookName = new System.Windows.Forms.Label();
            this.TBPrice = new System.Windows.Forms.Label();
            this.LblBorrowDate = new System.Windows.Forms.Label();
            this.DTPBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.LblMail = new System.Windows.Forms.Label();
            this.TBTC = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAddStudent
            // 
            this.LblAddStudent.AutoSize = true;
            this.LblAddStudent.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAddStudent.Location = new System.Drawing.Point(111, 31);
            this.LblAddStudent.Name = "LblAddStudent";
            this.LblAddStudent.Size = new System.Drawing.Size(145, 24);
            this.LblAddStudent.TabIndex = 1;
            this.LblAddStudent.Text = "Kitap Emanet Et";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.Location = new System.Drawing.Point(315, 311);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 30;
            this.BtnReset.Text = "Sıfırla";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8F);
            this.label2.Location = new System.Drawing.Point(205, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "*Kişi öğrenci ise %50 indirimli kapora öder.";
            // 
            // TBStudentNo
            // 
            this.TBStudentNo.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBStudentNo.Location = new System.Drawing.Point(111, 167);
            this.TBStudentNo.Name = "TBStudentNo";
            this.TBStudentNo.ReadOnly = true;
            this.TBStudentNo.Size = new System.Drawing.Size(278, 24);
            this.TBStudentNo.TabIndex = 20;
            this.TBStudentNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblStudentNo
            // 
            this.LblStudentNo.AutoSize = true;
            this.LblStudentNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStudentNo.Location = new System.Drawing.Point(15, 168);
            this.LblStudentNo.Name = "LblStudentNo";
            this.LblStudentNo.Size = new System.Drawing.Size(90, 19);
            this.LblStudentNo.TabIndex = 19;
            this.LblStudentNo.Text = "Öğrenci No*";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Location = new System.Drawing.Point(234, 311);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 29;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TBPhone
            // 
            this.TBPhone.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBPhone.Location = new System.Drawing.Point(111, 137);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.ReadOnly = true;
            this.TBPhone.Size = new System.Drawing.Size(278, 24);
            this.TBPhone.TabIndex = 11;
            this.TBPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPhone.Location = new System.Drawing.Point(48, 142);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(57, 19);
            this.LblPhone.TabIndex = 10;
            this.LblPhone.Text = "Telefon";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.LblAddStudent);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 85);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBEmail.Location = new System.Drawing.Point(111, 107);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.ReadOnly = true;
            this.TBEmail.Size = new System.Drawing.Size(278, 24);
            this.TBEmail.TabIndex = 9;
            this.TBEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
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
            this.TBSurname.ReadOnly = true;
            this.TBSurname.Size = new System.Drawing.Size(278, 24);
            this.TBSurname.TabIndex = 3;
            this.TBSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSurname.Location = new System.Drawing.Point(29, 55);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(76, 19);
            this.LblSurname.TabIndex = 2;
            this.LblSurname.Text = "Üye Soyad";
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBName.Location = new System.Drawing.Point(111, 23);
            this.TBName.Name = "TBName";
            this.TBName.ReadOnly = true;
            this.TBName.Size = new System.Drawing.Size(278, 24);
            this.TBName.TabIndex = 1;
            this.TBName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(46, 28);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(59, 19);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Üye Adı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CBBookName);
            this.panel2.Controls.Add(this.LblBookName);
            this.panel2.Controls.Add(this.TBPrice);
            this.panel2.Controls.Add(this.LblBorrowDate);
            this.panel2.Controls.Add(this.DTPBorrowDate);
            this.panel2.Controls.Add(this.BtnReset);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TBStudentNo);
            this.panel2.Controls.Add(this.LblStudentNo);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.TBPhone);
            this.panel2.Controls.Add(this.LblPhone);
            this.panel2.Controls.Add(this.TBEmail);
            this.panel2.Controls.Add(this.LblMail);
            this.panel2.Controls.Add(this.TBTC);
            this.panel2.Controls.Add(this.LblTC);
            this.panel2.Controls.Add(this.TBSurname);
            this.panel2.Controls.Add(this.LblSurname);
            this.panel2.Controls.Add(this.TBName);
            this.panel2.Controls.Add(this.LblName);
            this.panel2.Location = new System.Drawing.Point(269, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 397);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(264, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bir kişi en fazla 3 kitap alabilir.";
            // 
            // CBBookName
            // 
            this.CBBookName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBookName.Font = new System.Drawing.Font("Calibri", 10F);
            this.CBBookName.FormattingEnabled = true;
            this.CBBookName.Location = new System.Drawing.Point(111, 197);
            this.CBBookName.Name = "CBBookName";
            this.CBBookName.Size = new System.Drawing.Size(278, 23);
            this.CBBookName.TabIndex = 27;
            this.CBBookName.SelectedIndexChanged += new System.EventHandler(this.CBBookName_SelectedIndexChanged);
            this.CBBookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBookName.Location = new System.Drawing.Point(38, 201);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(67, 19);
            this.LblBookName.TabIndex = 26;
            this.LblBookName.Text = "Kitap Adı";
            // 
            // TBPrice
            // 
            this.TBPrice.AutoSize = true;
            this.TBPrice.Font = new System.Drawing.Font("Calibri", 12F);
            this.TBPrice.Location = new System.Drawing.Point(345, 271);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.Size = new System.Drawing.Size(44, 19);
            this.TBPrice.TabIndex = 25;
            this.TBPrice.Text = "Ücret";
            // 
            // LblBorrowDate
            // 
            this.LblBorrowDate.AutoSize = true;
            this.LblBorrowDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBorrowDate.Location = new System.Drawing.Point(7, 230);
            this.LblBorrowDate.Name = "LblBorrowDate";
            this.LblBorrowDate.Size = new System.Drawing.Size(98, 19);
            this.LblBorrowDate.TabIndex = 24;
            this.LblBorrowDate.Text = "Emanet Tarihi";
            // 
            // DTPBorrowDate
            // 
            this.DTPBorrowDate.CustomFormat = "dd/MM/yyyy";
            this.DTPBorrowDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.DTPBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPBorrowDate.Location = new System.Drawing.Point(111, 226);
            this.DTPBorrowDate.Name = "DTPBorrowDate";
            this.DTPBorrowDate.Size = new System.Drawing.Size(278, 24);
            this.DTPBorrowDate.TabIndex = 28;
            this.DTPBorrowDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMail.Location = new System.Drawing.Point(60, 112);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(45, 19);
            this.LblMail.TabIndex = 8;
            this.LblMail.Text = "Email";
            // 
            // TBTC
            // 
            this.TBTC.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBTC.Location = new System.Drawing.Point(111, 77);
            this.TBTC.Name = "TBTC";
            this.TBTC.ReadOnly = true;
            this.TBTC.Size = new System.Drawing.Size(278, 24);
            this.TBTC.TabIndex = 5;
            this.TBTC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.BtnSearch);
            this.panel3.Controls.Add(this.TBSearch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(14, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 397);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.Location = new System.Drawing.Point(83, 239);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 23;
            this.BtnSearch.Text = "Ara";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TBSearch
            // 
            this.TBSearch.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBSearch.Location = new System.Drawing.Point(14, 200);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(218, 24);
            this.TBSearch.TabIndex = 24;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(26, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "TC Numarası İle Üye Bul";
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
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            this.errorProvider3.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider3.Icon")));
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            this.errorProvider4.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider4.Icon")));
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            this.errorProvider5.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider5.Icon")));
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(707, 512);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Calibri", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Alınmış Kitap";
            this.Load += new System.EventHandler(this.BorrowBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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

        private System.Windows.Forms.Label LblAddStudent;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBStudentNo;
        private System.Windows.Forms.Label LblStudentNo;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.TextBox TBSurname;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblBorrowDate;
        private System.Windows.Forms.DateTimePicker DTPBorrowDate;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.TextBox TBTC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TBPrice;
        private System.Windows.Forms.ComboBox CBBookName;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
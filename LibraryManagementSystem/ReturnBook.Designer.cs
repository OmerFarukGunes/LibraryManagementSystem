
namespace LibraryManagementSystem
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVBooks = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.DTPPublish = new System.Windows.Forms.DateTimePicker();
            this.LblBorrowedDate = new System.Windows.Forms.Label();
            this.TBBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.BtnSearch);
            this.panel3.Controls.Add(this.TBSearch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 397);
            this.panel3.TabIndex = 10;
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
            this.BtnSearch.TabIndex = 25;
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
            // DGVBooks
            // 
            this.DGVBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBooks.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.DGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBooks.Location = new System.Drawing.Point(267, 12);
            this.DGVBooks.Name = "DGVBooks";
            this.DGVBooks.ReadOnly = true;
            this.DGVBooks.Size = new System.Drawing.Size(707, 397);
            this.DGVBooks.TabIndex = 11;
            this.DGVBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBooks_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.TBTC);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.DTPReturnDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TBPrice);
            this.panel2.Controls.Add(this.LblPrice);
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.DTPPublish);
            this.panel2.Controls.Add(this.LblBorrowedDate);
            this.panel2.Controls.Add(this.TBBookName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 249);
            this.panel2.TabIndex = 12;
            // 
            // TBTC
            // 
            this.TBTC.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBTC.Location = new System.Drawing.Point(372, 22);
            this.TBTC.Name = "TBTC";
            this.TBTC.ReadOnly = true;
            this.TBTC.Size = new System.Drawing.Size(278, 24);
            this.TBTC.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(286, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Alıcı TC No";
            // 
            // DTPReturnDate
            // 
            this.DTPReturnDate.CustomFormat = "dd/MM/yyyy";
            this.DTPReturnDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.DTPReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPReturnDate.Location = new System.Drawing.Point(586, 97);
            this.DTPReturnDate.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DTPReturnDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DTPReturnDate.Name = "DTPReturnDate";
            this.DTPReturnDate.Size = new System.Drawing.Size(279, 24);
            this.DTPReturnDate.TabIndex = 29;
            this.DTPReturnDate.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.DTPReturnDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(486, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Alınma Tarihi";
            // 
            // TBPrice
            // 
            this.TBPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBPrice.Location = new System.Drawing.Point(586, 57);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.ReadOnly = true;
            this.TBPrice.Size = new System.Drawing.Size(278, 24);
            this.TBPrice.TabIndex = 28;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPrice.Location = new System.Drawing.Point(536, 62);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(44, 19);
            this.LblPrice.TabIndex = 32;
            this.LblPrice.Text = "Ücret";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Location = new System.Drawing.Point(777, 178);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 31;
            this.BtnCancel.Text = "İptal";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Location = new System.Drawing.Point(696, 178);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 30;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DTPPublish
            // 
            this.DTPPublish.CustomFormat = "dd/MM/yyyy";
            this.DTPPublish.Font = new System.Drawing.Font("Calibri", 10F);
            this.DTPPublish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPPublish.Location = new System.Drawing.Point(146, 96);
            this.DTPPublish.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DTPPublish.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DTPPublish.Name = "DTPPublish";
            this.DTPPublish.Size = new System.Drawing.Size(279, 24);
            this.DTPPublish.TabIndex = 28;
            this.DTPPublish.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.DTPPublish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblBorrowedDate
            // 
            this.LblBorrowedDate.AutoSize = true;
            this.LblBorrowedDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBorrowedDate.Location = new System.Drawing.Point(43, 100);
            this.LblBorrowedDate.Name = "LblBorrowedDate";
            this.LblBorrowedDate.Size = new System.Drawing.Size(98, 19);
            this.LblBorrowedDate.TabIndex = 23;
            this.LblBorrowedDate.Text = "Emanet Tarihi";
            // 
            // TBBookName
            // 
            this.TBBookName.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBBookName.Location = new System.Drawing.Point(147, 57);
            this.TBBookName.Name = "TBBookName";
            this.TBBookName.ReadOnly = true;
            this.TBBookName.Size = new System.Drawing.Size(278, 24);
            this.TBBookName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kitap Adı";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(997, 421);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGVBooks);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Calibri", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İade";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVBooks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DTPReturnDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DateTimePicker DTPPublish;
        private System.Windows.Forms.Label LblBorrowedDate;
        private System.Windows.Forms.TextBox TBBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBTC;
        private System.Windows.Forms.Label label4;
    }
}
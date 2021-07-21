
namespace LibraryManagementSystem
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblAddBook = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.DTPPublish = new System.Windows.Forms.DateTimePicker();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.LblStock = new System.Windows.Forms.Label();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblBookPublicationDate = new System.Windows.Forms.Label();
            this.TBPublication = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBBookAuthor = new System.Windows.Forms.TextBox();
            this.LblBookAuthor = new System.Windows.Forms.Label();
            this.TBBookName = new System.Windows.Forms.TextBox();
            this.LblBookName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.LblAddBook);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 85);
            this.panel1.TabIndex = 1;
            // 
            // LblAddBook
            // 
            this.LblAddBook.AutoSize = true;
            this.LblAddBook.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAddBook.Location = new System.Drawing.Point(94, 33);
            this.LblAddBook.Name = "LblAddBook";
            this.LblAddBook.Size = new System.Drawing.Size(94, 24);
            this.LblAddBook.TabIndex = 1;
            this.LblAddBook.Text = "Kitap Ekle";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.DTPPublish);
            this.panel2.Controls.Add(this.TBStock);
            this.panel2.Controls.Add(this.LblStock);
            this.panel2.Controls.Add(this.TBPrice);
            this.panel2.Controls.Add(this.LblPrice);
            this.panel2.Controls.Add(this.LblBookPublicationDate);
            this.panel2.Controls.Add(this.TBPublication);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TBBookAuthor);
            this.panel2.Controls.Add(this.LblBookAuthor);
            this.panel2.Controls.Add(this.TBBookName);
            this.panel2.Controls.Add(this.LblBookName);
            this.panel2.Location = new System.Drawing.Point(258, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 323);
            this.panel2.TabIndex = 2;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Location = new System.Drawing.Point(314, 207);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "Sıfırla";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Location = new System.Drawing.Point(212, 207);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DTPPublish
            // 
            this.DTPPublish.CustomFormat = "dd/MM/yyyy";
            this.DTPPublish.Font = new System.Drawing.Font("Calibri", 10F);
            this.DTPPublish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPPublish.Location = new System.Drawing.Point(111, 105);
            this.DTPPublish.Name = "DTPPublish";
            this.DTPPublish.Size = new System.Drawing.Size(279, 24);
            this.DTPPublish.TabIndex = 7;
            this.DTPPublish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // TBStock
            // 
            this.TBStock.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBStock.Location = new System.Drawing.Point(112, 159);
            this.TBStock.Name = "TBStock";
            this.TBStock.Size = new System.Drawing.Size(278, 24);
            this.TBStock.TabIndex = 11;
            this.TBStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStock.Location = new System.Drawing.Point(70, 164);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(36, 19);
            this.LblStock.TabIndex = 10;
            this.LblStock.Text = "Stok";
            // 
            // TBPrice
            // 
            this.TBPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBPrice.Location = new System.Drawing.Point(112, 132);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.Size = new System.Drawing.Size(278, 24);
            this.TBPrice.TabIndex = 9;
            this.TBPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPrice.Location = new System.Drawing.Point(62, 137);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(44, 19);
            this.LblPrice.TabIndex = 8;
            this.LblPrice.Text = "Ücret";
            // 
            // LblBookPublicationDate
            // 
            this.LblBookPublicationDate.AutoSize = true;
            this.LblBookPublicationDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBookPublicationDate.Location = new System.Drawing.Point(22, 110);
            this.LblBookPublicationDate.Name = "LblBookPublicationDate";
            this.LblBookPublicationDate.Size = new System.Drawing.Size(83, 19);
            this.LblBookPublicationDate.TabIndex = 6;
            this.LblBookPublicationDate.Text = "Yayın Tarihi";
            // 
            // TBPublication
            // 
            this.TBPublication.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBPublication.Location = new System.Drawing.Point(111, 77);
            this.TBPublication.Name = "TBPublication";
            this.TBPublication.Size = new System.Drawing.Size(278, 24);
            this.TBPublication.TabIndex = 5;
            this.TBPublication.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yayın Evi";
            // 
            // TBBookAuthor
            // 
            this.TBBookAuthor.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBBookAuthor.Location = new System.Drawing.Point(111, 50);
            this.TBBookAuthor.Name = "TBBookAuthor";
            this.TBBookAuthor.Size = new System.Drawing.Size(278, 24);
            this.TBBookAuthor.TabIndex = 3;
            this.TBBookAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblBookAuthor
            // 
            this.LblBookAuthor.AutoSize = true;
            this.LblBookAuthor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBookAuthor.Location = new System.Drawing.Point(21, 55);
            this.LblBookAuthor.Name = "LblBookAuthor";
            this.LblBookAuthor.Size = new System.Drawing.Size(84, 19);
            this.LblBookAuthor.TabIndex = 2;
            this.LblBookAuthor.Text = "Kitap Yazarı";
            // 
            // TBBookName
            // 
            this.TBBookName.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBBookName.Location = new System.Drawing.Point(111, 23);
            this.TBBookName.Name = "TBBookName";
            this.TBBookName.Size = new System.Drawing.Size(278, 24);
            this.TBBookName.TabIndex = 1;
            this.TBBookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBookName.Location = new System.Drawing.Point(38, 28);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(67, 19);
            this.LblBookName.TabIndex = 0;
            this.LblBookName.Text = "Kitap Adı";
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
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(684, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblAddBook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TBStock;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblBookPublicationDate;
        private System.Windows.Forms.TextBox TBPublication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBBookAuthor;
        private System.Windows.Forms.Label LblBookAuthor;
        private System.Windows.Forms.TextBox TBBookName;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.DateTimePicker DTPPublish;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

namespace LibraryManagementSystem
{
    partial class ViewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooks));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblBookName = new System.Windows.Forms.Label();
            this.TBSearchBook = new System.Windows.Forms.TextBox();
            this.DGVBooks = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
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
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(548, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kİtapları Görüntüle";
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Font = new System.Drawing.Font("Calibri", 12F);
            this.LblBookName.Location = new System.Drawing.Point(315, 121);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(86, 24);
            this.LblBookName.TabIndex = 1;
            this.LblBookName.Text = "Kitap Adı";
            // 
            // TBSearchBook
            // 
            this.TBSearchBook.Font = new System.Drawing.Font("Calibri", 12F);
            this.TBSearchBook.Location = new System.Drawing.Point(388, 118);
            this.TBSearchBook.Name = "TBSearchBook";
            this.TBSearchBook.Size = new System.Drawing.Size(204, 32);
            this.TBSearchBook.TabIndex = 2;
            this.TBSearchBook.TextChanged += new System.EventHandler(this.TBSearchBook_TextChanged);
            // 
            // DGVBooks
            // 
            this.DGVBooks.AllowUserToAddRows = false;
            this.DGVBooks.AllowUserToDeleteRows = false;
            this.DGVBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBooks.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.DGVBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBooks.Location = new System.Drawing.Point(12, 149);
            this.DGVBooks.Name = "DGVBooks";
            this.DGVBooks.ReadOnly = true;
            this.DGVBooks.RowHeadersWidth = 51;
            this.DGVBooks.Size = new System.Drawing.Size(967, 296);
            this.DGVBooks.TabIndex = 4;
            this.DGVBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBooks_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.BtnDelete);
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
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 259);
            this.panel2.TabIndex = 5;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Location = new System.Drawing.Point(784, 178);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(82, 23);
            this.BtnDelete.TabIndex = 31;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Location = new System.Drawing.Point(696, 178);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(82, 23);
            this.BtnCancel.TabIndex = 30;
            this.BtnCancel.Text = "İptal";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Location = new System.Drawing.Point(615, 178);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 29;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DTPPublish
            // 
            this.DTPPublish.CustomFormat = "dd/MM/yyyy";
            this.DTPPublish.Font = new System.Drawing.Font("Calibri", 10F);
            this.DTPPublish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPPublish.Location = new System.Drawing.Point(579, 52);
            this.DTPPublish.Name = "DTPPublish";
            this.DTPPublish.Size = new System.Drawing.Size(300, 28);
            this.DTPPublish.TabIndex = 24;
            this.DTPPublish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // TBStock
            // 
            this.TBStock.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBStock.Location = new System.Drawing.Point(580, 106);
            this.TBStock.Name = "TBStock";
            this.TBStock.Size = new System.Drawing.Size(299, 28);
            this.TBStock.TabIndex = 27;
            this.TBStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStock.Location = new System.Drawing.Point(537, 111);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(46, 24);
            this.LblStock.TabIndex = 26;
            this.LblStock.Text = "Stok";
            // 
            // TBPrice
            // 
            this.TBPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBPrice.Location = new System.Drawing.Point(580, 79);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.Size = new System.Drawing.Size(299, 28);
            this.TBPrice.TabIndex = 25;
            this.TBPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPrice.Location = new System.Drawing.Point(529, 84);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(55, 24);
            this.LblPrice.TabIndex = 24;
            this.LblPrice.Text = "Ücret";
            // 
            // LblBookPublicationDate
            // 
            this.LblBookPublicationDate.AutoSize = true;
            this.LblBookPublicationDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBookPublicationDate.Location = new System.Drawing.Point(490, 57);
            this.LblBookPublicationDate.Name = "LblBookPublicationDate";
            this.LblBookPublicationDate.Size = new System.Drawing.Size(105, 24);
            this.LblBookPublicationDate.TabIndex = 23;
            this.LblBookPublicationDate.Text = "Yayın Tarihi";
            // 
            // TBPublication
            // 
            this.TBPublication.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBPublication.Location = new System.Drawing.Point(146, 106);
            this.TBPublication.Name = "TBPublication";
            this.TBPublication.Size = new System.Drawing.Size(299, 28);
            this.TBPublication.TabIndex = 22;
            this.TBPublication.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Yayın Evi";
            // 
            // TBBookAuthor
            // 
            this.TBBookAuthor.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBBookAuthor.Location = new System.Drawing.Point(146, 79);
            this.TBBookAuthor.Name = "TBBookAuthor";
            this.TBBookAuthor.Size = new System.Drawing.Size(299, 28);
            this.TBBookAuthor.TabIndex = 20;
            this.TBBookAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblBookAuthor
            // 
            this.LblBookAuthor.AutoSize = true;
            this.LblBookAuthor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBookAuthor.Location = new System.Drawing.Point(56, 84);
            this.LblBookAuthor.Name = "LblBookAuthor";
            this.LblBookAuthor.Size = new System.Drawing.Size(107, 24);
            this.LblBookAuthor.TabIndex = 19;
            this.LblBookAuthor.Text = "Kitap Yazarı";
            // 
            // TBBookName
            // 
            this.TBBookName.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBBookName.Location = new System.Drawing.Point(146, 52);
            this.TBBookName.Name = "TBBookName";
            this.TBBookName.Size = new System.Drawing.Size(299, 28);
            this.TBBookName.TabIndex = 18;
            this.TBBookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kitap Adı";
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
            // ViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGVBooks);
            this.Controls.Add(this.TBSearchBook);
            this.Controls.Add(this.LblBookName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitapları Görüntüle";
            this.Load += new System.EventHandler(this.ViewBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.TextBox TBSearchBook;
        private System.Windows.Forms.DataGridView DGVBooks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DTPPublish;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}
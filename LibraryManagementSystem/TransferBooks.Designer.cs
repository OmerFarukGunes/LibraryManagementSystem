
namespace LibraryManagementSystem
{
    partial class TransferBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferBooks));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TBBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBSearchBook = new System.Windows.Forms.TextBox();
            this.LblBookName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblLibrary = new System.Windows.Forms.Label();
            this.CBLibraries = new System.Windows.Forms.ComboBox();
            this.TBBookID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVBooks = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Location = new System.Drawing.Point(777, 178);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 40;
            this.BtnCancel.Text = "İptal";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Location = new System.Drawing.Point(696, 178);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 39;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TBBookName
            // 
            this.TBBookName.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBBookName.Location = new System.Drawing.Point(146, 52);
            this.TBBookName.Name = "TBBookName";
            this.TBBookName.ReadOnly = true;
            this.TBBookName.Size = new System.Drawing.Size(278, 24);
            this.TBBookName.TabIndex = 18;
            this.TBBookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kitap Adı";
            // 
            // TBSearchBook
            // 
            this.TBSearchBook.Font = new System.Drawing.Font("Calibri", 12F);
            this.TBSearchBook.Location = new System.Drawing.Point(388, 113);
            this.TBSearchBook.Name = "TBSearchBook";
            this.TBSearchBook.Size = new System.Drawing.Size(195, 27);
            this.TBSearchBook.TabIndex = 8;
            this.TBSearchBook.TextChanged += new System.EventHandler(this.TBSearchBook_TextChanged);
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Font = new System.Drawing.Font("Calibri", 12F);
            this.LblBookName.Location = new System.Drawing.Point(315, 116);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(67, 19);
            this.LblBookName.TabIndex = 7;
            this.LblBookName.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(548, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Transferi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 100);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.TBStock);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.LblLibrary);
            this.panel2.Controls.Add(this.CBLibraries);
            this.panel2.Controls.Add(this.TBBookID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.TBBookName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 259);
            this.panel2.TabIndex = 11;
            // 
            // TBStock
            // 
            this.TBStock.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBStock.Location = new System.Drawing.Point(574, 51);
            this.TBStock.Name = "TBStock";
            this.TBStock.Size = new System.Drawing.Size(278, 24);
            this.TBStock.TabIndex = 37;
            this.TBStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(529, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Adet";
            // 
            // LblLibrary
            // 
            this.LblLibrary.AutoSize = true;
            this.LblLibrary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLibrary.Location = new System.Drawing.Point(490, 86);
            this.LblLibrary.Name = "LblLibrary";
            this.LblLibrary.Size = new System.Drawing.Size(78, 19);
            this.LblLibrary.TabIndex = 35;
            this.LblLibrary.Text = "Kütüphane";
            // 
            // CBLibraries
            // 
            this.CBLibraries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLibraries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBLibraries.FormattingEnabled = true;
            this.CBLibraries.Location = new System.Drawing.Point(574, 81);
            this.CBLibraries.Name = "CBLibraries";
            this.CBLibraries.Size = new System.Drawing.Size(278, 24);
            this.CBLibraries.TabIndex = 38;
            this.CBLibraries.SelectedIndexChanged += new System.EventHandler(this.CBLibraries_SelectedIndexChanged);
            this.CBLibraries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // TBBookID
            // 
            this.TBBookID.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBBookID.Location = new System.Drawing.Point(146, 82);
            this.TBBookID.Name = "TBBookID";
            this.TBBookID.ReadOnly = true;
            this.TBBookID.Size = new System.Drawing.Size(278, 24);
            this.TBBookID.TabIndex = 33;
            this.TBBookID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Kitap ID";
            // 
            // DGVBooks
            // 
            this.DGVBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBooks.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.DGVBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBooks.Location = new System.Drawing.Point(12, 146);
            this.DGVBooks.Name = "DGVBooks";
            this.DGVBooks.ReadOnly = true;
            this.DGVBooks.Size = new System.Drawing.Size(967, 296);
            this.DGVBooks.TabIndex = 10;
            this.DGVBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBooks_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // TransferBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.TBSearchBook);
            this.Controls.Add(this.LblBookName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGVBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransferBooks";
            this.Text = "Kitap Transfer";
            this.Load += new System.EventHandler(this.TransferBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TBBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBSearchBook;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVBooks;
        private System.Windows.Forms.Label LblLibrary;
        private System.Windows.Forms.ComboBox CBLibraries;
        private System.Windows.Forms.TextBox TBBookID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
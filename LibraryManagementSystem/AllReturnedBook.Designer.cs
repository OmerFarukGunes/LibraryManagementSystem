
namespace LibraryManagementSystem
{
    partial class AllReturnedBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllReturnedBook));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBSearchBook = new System.Windows.Forms.TextBox();
            this.LblBookName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).BeginInit();
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
            // TBSearchBook
            // 
            this.TBSearchBook.Font = new System.Drawing.Font("Calibri", 12F);
            this.TBSearchBook.Location = new System.Drawing.Point(396, 124);
            this.TBSearchBook.Name = "TBSearchBook";
            this.TBSearchBook.Size = new System.Drawing.Size(203, 27);
            this.TBSearchBook.TabIndex = 12;
            this.TBSearchBook.TextChanged += new System.EventHandler(this.TBSearchBook_TextChanged);
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Font = new System.Drawing.Font("Calibri", 12F);
            this.LblBookName.Location = new System.Drawing.Point(323, 128);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(67, 19);
            this.LblBookName.TabIndex = 11;
            this.LblBookName.Text = "Kitap Adı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(20, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 100);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(548, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "İade Edilmiş Kitaplar";
            // 
            // DGVBooks
            // 
            this.DGVBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBooks.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.DGVBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBooks.Location = new System.Drawing.Point(20, 155);
            this.DGVBooks.Name = "DGVBooks";
            this.DGVBooks.ReadOnly = true;
            this.DGVBooks.Size = new System.Drawing.Size(976, 370);
            this.DGVBooks.TabIndex = 14;
            // 
            // AllReturnedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.TBSearchBook);
            this.Controls.Add(this.LblBookName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AllReturnedBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İade Edilmiş Kitaplar";
            this.Load += new System.EventHandler(this.AllReturnedBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBSearchBook;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVBooks;
    }
}
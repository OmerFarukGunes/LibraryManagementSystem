
namespace LibraryManagementSystem
{
    partial class ViewLibraries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLibraries));
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBLocation = new System.Windows.Forms.TextBox();
            this.LblLocation = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.DGVULibrary = new System.Windows.Forms.DataGridView();
            this.TBSearchBook = new System.Windows.Forms.TextBox();
            this.LblBookName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVULibrary)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.TBLocation);
            this.panel2.Controls.Add(this.LblLocation);
            this.panel2.Controls.Add(this.TBName);
            this.panel2.Controls.Add(this.LblName);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Location = new System.Drawing.Point(12, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 190);
            this.panel2.TabIndex = 16;
            // 
            // TBLocation
            // 
            this.TBLocation.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBLocation.Location = new System.Drawing.Point(587, 38);
            this.TBLocation.Name = "TBLocation";
            this.TBLocation.Size = new System.Drawing.Size(278, 24);
            this.TBLocation.TabIndex = 35;
            this.TBLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLocation.Location = new System.Drawing.Point(528, 43);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(53, 19);
            this.LblLocation.TabIndex = 34;
            this.LblLocation.Text = "Konum";
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBName.Location = new System.Drawing.Point(171, 38);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(278, 24);
            this.TBName.TabIndex = 33;
            this.TBName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(139, 43);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(26, 19);
            this.LblName.TabIndex = 32;
            this.LblName.Text = "Ad";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Location = new System.Drawing.Point(708, 94);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 37;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Location = new System.Drawing.Point(789, 94);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 38;
            this.BtnCancel.Text = "İptal";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Location = new System.Drawing.Point(627, 94);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 26;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DGVULibrary
            // 
            this.DGVULibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVULibrary.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.DGVULibrary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVULibrary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVULibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVULibrary.Location = new System.Drawing.Point(12, 145);
            this.DGVULibrary.Name = "DGVULibrary";
            this.DGVULibrary.ReadOnly = true;
            this.DGVULibrary.Size = new System.Drawing.Size(967, 296);
            this.DGVULibrary.TabIndex = 15;
            this.DGVULibrary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVULibrary_CellClick);
            // 
            // TBSearchBook
            // 
            this.TBSearchBook.Font = new System.Drawing.Font("Calibri", 12F);
            this.TBSearchBook.Location = new System.Drawing.Point(388, 114);
            this.TBSearchBook.Name = "TBSearchBook";
            this.TBSearchBook.Size = new System.Drawing.Size(201, 27);
            this.TBSearchBook.TabIndex = 14;
            this.TBSearchBook.TextChanged += new System.EventHandler(this.TBSearchBook_TextChanged);
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Font = new System.Drawing.Font("Calibri", 12F);
            this.LblBookName.Location = new System.Drawing.Point(273, 117);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(109, 19);
            this.LblBookName.TabIndex = 13;
            this.LblBookName.Text = "Kütüphane İsmi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 100);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(548, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kütüphaneleri Görüntüle";
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
            // ViewLibraries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGVULibrary);
            this.Controls.Add(this.TBSearchBook);
            this.Controls.Add(this.LblBookName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewLibraries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphaneleri Görüntüle";
            this.Load += new System.EventHandler(this.ViewLibraries_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVULibrary)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBLocation;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridView DGVULibrary;
        private System.Windows.Forms.TextBox TBSearchBook;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
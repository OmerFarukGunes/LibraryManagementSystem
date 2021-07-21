
namespace LibraryManagementSystem
{
    partial class ViewAuthorizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAuthorizer));
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.DGVUser = new System.Windows.Forms.DataGridView();
            this.TBSearchBook = new System.Windows.Forms.TextBox();
            this.LblBookName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBAuthorizeType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Location = new System.Drawing.Point(719, 127);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 39;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Location = new System.Drawing.Point(800, 127);
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
            this.BtnSave.Location = new System.Drawing.Point(638, 127);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 38;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DGVUser
            // 
            this.DGVUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUser.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.DGVUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUser.Location = new System.Drawing.Point(12, 149);
            this.DGVUser.Name = "DGVUser";
            this.DGVUser.ReadOnly = true;
            this.DGVUser.Size = new System.Drawing.Size(967, 296);
            this.DGVUser.TabIndex = 10;
            this.DGVUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUser_CellClick);
            // 
            // TBSearchBook
            // 
            this.TBSearchBook.Font = new System.Drawing.Font("Calibri", 12F);
            this.TBSearchBook.Location = new System.Drawing.Point(388, 118);
            this.TBSearchBook.Name = "TBSearchBook";
            this.TBSearchBook.Size = new System.Drawing.Size(214, 27);
            this.TBSearchBook.TabIndex = 8;
            this.TBSearchBook.TextChanged += new System.EventHandler(this.TBSearchBook_TextChanged);
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Font = new System.Drawing.Font("Calibri", 12F);
            this.LblBookName.Location = new System.Drawing.Point(344, 121);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(38, 19);
            this.LblBookName.TabIndex = 7;
            this.LblBookName.Text = "Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(548, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yetkilileri Görüntüle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.CBAuthorizeType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TBEmail);
            this.panel2.Controls.Add(this.LblPrice);
            this.panel2.Controls.Add(this.TBName);
            this.panel2.Controls.Add(this.LblName);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Location = new System.Drawing.Point(12, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 190);
            this.panel2.TabIndex = 11;
            // 
            // CBAuthorizeType
            // 
            this.CBAuthorizeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAuthorizeType.Font = new System.Drawing.Font("Calibri", 10F);
            this.CBAuthorizeType.FormattingEnabled = true;
            this.CBAuthorizeType.Location = new System.Drawing.Point(574, 38);
            this.CBAuthorizeType.Name = "CBAuthorizeType";
            this.CBAuthorizeType.Size = new System.Drawing.Size(299, 23);
            this.CBAuthorizeType.TabIndex = 37;
            this.CBAuthorizeType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(528, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Yetki";
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBEmail.Location = new System.Drawing.Point(171, 68);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(299, 24);
            this.TBEmail.TabIndex = 35;
            this.TBEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPrice.Location = new System.Drawing.Point(120, 73);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(45, 19);
            this.LblPrice.TabIndex = 34;
            this.LblPrice.Text = "Email";
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBName.Location = new System.Drawing.Point(171, 38);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(299, 24);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 100);
            this.panel1.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // ViewAuthorizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.DGVUser);
            this.Controls.Add(this.TBSearchBook);
            this.Controls.Add(this.LblBookName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewAuthorizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkilileri Görüntüle";
            this.Load += new System.EventHandler(this.ViewLibraries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridView DGVUser;
        private System.Windows.Forms.TextBox TBSearchBook;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBAuthorizeType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
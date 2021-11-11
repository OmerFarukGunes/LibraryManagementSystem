
namespace LibraryManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransferBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MemberDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllBorrowedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllReturnedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClose = new System.Windows.Forms.Button();
            this.DGVBooks = new System.Windows.Forms.DataGridView();
            this.TBSearchBook = new System.Windows.Forms.TextBox();
            this.AddAuthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListAuthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.MintCream;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitaplarToolStripMenuItem,
            this.MemberToolStripMenuItem,
            this.BorrowBookToolStripMenuItem,
            this.ReturnBookToolStripMenuItem,
            this.AllBorrowedBooksToolStripMenuItem,
            this.AllReturnedBooksToolStripMenuItem,
            this.AuthorizeToolStripMenuItem,
            this.LibraryToolStripMenuItem,
            this.ExitToolStripMenuItem,
            this.LoginToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1317, 72);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan;
            this.kitaplarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewBookToolStripMenuItem,
            this.ViewBookToolStripMenuItem,
            this.TransferBookToolStripMenuItem});
            this.kitaplarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitaplarToolStripMenuItem.Image")));
            this.kitaplarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(125, 68);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            this.kitaplarToolStripMenuItem.Visible = false;
            // 
            // AddNewBookToolStripMenuItem
            // 
            this.AddNewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddNewBookToolStripMenuItem.Image")));
            this.AddNewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewBookToolStripMenuItem.Name = "AddNewBookToolStripMenuItem";
            this.AddNewBookToolStripMenuItem.Size = new System.Drawing.Size(221, 56);
            this.AddNewBookToolStripMenuItem.Text = "Yeni Kitap Ekle";
            this.AddNewBookToolStripMenuItem.Click += new System.EventHandler(this.AddNewBookToolStripMenuItem_Click);
            // 
            // ViewBookToolStripMenuItem
            // 
            this.ViewBookToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ViewBookToolStripMenuItem.Image")));
            this.ViewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewBookToolStripMenuItem.Name = "ViewBookToolStripMenuItem";
            this.ViewBookToolStripMenuItem.Size = new System.Drawing.Size(221, 56);
            this.ViewBookToolStripMenuItem.Text = "Kitapları İncele";
            this.ViewBookToolStripMenuItem.Click += new System.EventHandler(this.ViewBookToolStripMenuItem_Click);
            // 
            // TransferBookToolStripMenuItem
            // 
            this.TransferBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TransferBookToolStripMenuItem.Image")));
            this.TransferBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TransferBookToolStripMenuItem.Name = "TransferBookToolStripMenuItem";
            this.TransferBookToolStripMenuItem.Size = new System.Drawing.Size(221, 56);
            this.TransferBookToolStripMenuItem.Text = "Kitap Transferi";
            this.TransferBookToolStripMenuItem.Click += new System.EventHandler(this.TransferBookToolStripMenuItem_Click);
            // 
            // MemberToolStripMenuItem
            // 
            this.MemberToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan;
            this.MemberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMemberToolStripMenuItem,
            this.MemberDetailsToolStripMenuItem});
            this.MemberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("MemberToolStripMenuItem.Image")));
            this.MemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem";
            this.MemberToolStripMenuItem.Size = new System.Drawing.Size(98, 68);
            this.MemberToolStripMenuItem.Text = "Üye";
            this.MemberToolStripMenuItem.Visible = false;
            // 
            // AddMemberToolStripMenuItem
            // 
            this.AddMemberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddMemberToolStripMenuItem.Image")));
            this.AddMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddMemberToolStripMenuItem.Name = "AddMemberToolStripMenuItem";
            this.AddMemberToolStripMenuItem.Size = new System.Drawing.Size(191, 56);
            this.AddMemberToolStripMenuItem.Text = "Üye Ekle";
            this.AddMemberToolStripMenuItem.Click += new System.EventHandler(this.AddMemberToolStripMenuItem_Click);
            // 
            // MemberDetailsToolStripMenuItem
            // 
            this.MemberDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MemberDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("MemberDetailsToolStripMenuItem.Image")));
            this.MemberDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MemberDetailsToolStripMenuItem.Name = "MemberDetailsToolStripMenuItem";
            this.MemberDetailsToolStripMenuItem.Size = new System.Drawing.Size(191, 56);
            this.MemberDetailsToolStripMenuItem.Text = "Üye Listesi";
            this.MemberDetailsToolStripMenuItem.Click += new System.EventHandler(this.MemberDetailsToolStripMenuItem_Click);
            // 
            // BorrowBookToolStripMenuItem
            // 
            this.BorrowBookToolStripMenuItem.Checked = true;
            this.BorrowBookToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BorrowBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("BorrowBookToolStripMenuItem.Image")));
            this.BorrowBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrowBookToolStripMenuItem.Name = "BorrowBookToolStripMenuItem";
            this.BorrowBookToolStripMenuItem.Size = new System.Drawing.Size(200, 68);
            this.BorrowBookToolStripMenuItem.Text = "Kitap Emanet Etme";
            this.BorrowBookToolStripMenuItem.Visible = false;
            this.BorrowBookToolStripMenuItem.Click += new System.EventHandler(this.BorrowBookToolStripMenuItem_Click);
            // 
            // ReturnBookToolStripMenuItem
            // 
            this.ReturnBookToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan;
            this.ReturnBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ReturnBookToolStripMenuItem.Image")));
            this.ReturnBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReturnBookToolStripMenuItem.Name = "ReturnBookToolStripMenuItem";
            this.ReturnBookToolStripMenuItem.Size = new System.Drawing.Size(179, 68);
            this.ReturnBookToolStripMenuItem.Text = "Kitap İade Etme";
            this.ReturnBookToolStripMenuItem.Visible = false;
            this.ReturnBookToolStripMenuItem.Click += new System.EventHandler(this.ReturnBookToolStripMenuItem_Click);
            // 
            // AllBorrowedBooksToolStripMenuItem
            // 
            this.AllBorrowedBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AllBorrowedBooksToolStripMenuItem.Image")));
            this.AllBorrowedBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AllBorrowedBooksToolStripMenuItem.Name = "AllBorrowedBooksToolStripMenuItem";
            this.AllBorrowedBooksToolStripMenuItem.Size = new System.Drawing.Size(224, 68);
            this.AllBorrowedBooksToolStripMenuItem.Text = "Emanet Edilen Kitaplar";
            this.AllBorrowedBooksToolStripMenuItem.Visible = false;
            this.AllBorrowedBooksToolStripMenuItem.Click += new System.EventHandler(this.AllBorrowedBooksToolStripMenuItem_Click);
            // 
            // AllReturnedBooksToolStripMenuItem
            // 
            this.AllReturnedBooksToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan;
            this.AllReturnedBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AllReturnedBooksToolStripMenuItem.Image")));
            this.AllReturnedBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AllReturnedBooksToolStripMenuItem.Name = "AllReturnedBooksToolStripMenuItem";
            this.AllReturnedBooksToolStripMenuItem.Size = new System.Drawing.Size(203, 68);
            this.AllReturnedBooksToolStripMenuItem.Text = "İade Edilen Kitaplar";
            this.AllReturnedBooksToolStripMenuItem.Visible = false;
            this.AllReturnedBooksToolStripMenuItem.Click += new System.EventHandler(this.AllReturnedBooksToolStripMenuItem_Click);
            // 
            // LibraryToolStripMenuItem
            // 
            this.LibraryToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan;
            this.LibraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddLibraryToolStripMenuItem,
            this.ListLibraryToolStripMenuItem});
            this.LibraryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LibraryToolStripMenuItem.Image")));
            this.LibraryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LibraryToolStripMenuItem.Name = "LibraryToolStripMenuItem";
            this.LibraryToolStripMenuItem.Size = new System.Drawing.Size(161, 68);
            this.LibraryToolStripMenuItem.Text = "Kütüphaneler";
            this.LibraryToolStripMenuItem.Visible = false;
            // 
            // AddLibraryToolStripMenuItem
            // 
            this.AddLibraryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddLibraryToolStripMenuItem.Image")));
            this.AddLibraryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddLibraryToolStripMenuItem.Name = "AddLibraryToolStripMenuItem";
            this.AddLibraryToolStripMenuItem.Size = new System.Drawing.Size(283, 56);
            this.AddLibraryToolStripMenuItem.Text = "Kütüphane Ekle";
            this.AddLibraryToolStripMenuItem.Click += new System.EventHandler(this.AddLibraryToolStripMenuItem_Click);
            // 
            // ListLibraryToolStripMenuItem
            // 
            this.ListLibraryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListLibraryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ListLibraryToolStripMenuItem.Image")));
            this.ListLibraryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ListLibraryToolStripMenuItem.Name = "ListLibraryToolStripMenuItem";
            this.ListLibraryToolStripMenuItem.Size = new System.Drawing.Size(283, 56);
            this.ListLibraryToolStripMenuItem.Text = "Kütüphaneleri Görüntüle";
            this.ListLibraryToolStripMenuItem.Click += new System.EventHandler(this.ListLibraryToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExitToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.ExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolStripMenuItem.Image")));
            this.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(162, 68);
            this.ExitToolStripMenuItem.Text = "Hesabı Kapat";
            this.ExitToolStripMenuItem.Visible = false;
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LoginToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.LoginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LoginToolStripMenuItem.Image")));
            this.LoginToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(144, 68);
            this.LoginToolStripMenuItem.Text = "Giriş Yap";
            this.LoginToolStripMenuItem.Visible = false;
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click_1);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.SeaShell;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.BtnClose.ForeColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(1247, 699);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnClose.Size = new System.Drawing.Size(58, 55);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // DGVBooks
            // 
            this.DGVBooks.AllowUserToAddRows = false;
            this.DGVBooks.AllowUserToDeleteRows = false;
            this.DGVBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBooks.BackgroundColor = System.Drawing.Color.Snow;
            this.DGVBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBooks.Location = new System.Drawing.Point(204, 258);
            this.DGVBooks.Name = "DGVBooks";
            this.DGVBooks.ReadOnly = true;
            this.DGVBooks.RowHeadersWidth = 51;
            this.DGVBooks.Size = new System.Drawing.Size(967, 296);
            this.DGVBooks.TabIndex = 7;
            // 
            // TBSearchBook
            // 
            this.TBSearchBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBSearchBook.Font = new System.Drawing.Font("Calibri", 12F);
            this.TBSearchBook.Location = new System.Drawing.Point(558, 220);
            this.TBSearchBook.Name = "TBSearchBook";
            this.TBSearchBook.Size = new System.Drawing.Size(255, 32);
            this.TBSearchBook.TabIndex = 6;
            this.TBSearchBook.Text = "Kitap Ara";
            this.TBSearchBook.TextChanged += new System.EventHandler(this.TBSearchBook_TextChanged);
            // 
            // AddAuthToolStripMenuItem
            // 
            this.AddAuthToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddAuthToolStripMenuItem.Image")));
            this.AddAuthToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddAuthToolStripMenuItem.Name = "AddAuthToolStripMenuItem";
            this.AddAuthToolStripMenuItem.Size = new System.Drawing.Size(254, 56);
            this.AddAuthToolStripMenuItem.Text = "Yetkili Ekle";
            this.AddAuthToolStripMenuItem.Click += new System.EventHandler(this.AddAuthToolStripMenuItem_Click);
            // 
            // ListAuthToolStripMenuItem
            // 
            this.ListAuthToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListAuthToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ListAuthToolStripMenuItem.Image")));
            this.ListAuthToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ListAuthToolStripMenuItem.Name = "ListAuthToolStripMenuItem";
            this.ListAuthToolStripMenuItem.Size = new System.Drawing.Size(254, 56);
            this.ListAuthToolStripMenuItem.Text = "Yetkilileri Görüntüle";
            this.ListAuthToolStripMenuItem.Click += new System.EventHandler(this.ListAuthToolStripMenuItem_Click);
            // 
            // AuthorizeToolStripMenuItem
            // 
            this.AuthorizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAuthToolStripMenuItem,
            this.ListAuthToolStripMenuItem});
            this.AuthorizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AuthorizeToolStripMenuItem.Image")));
            this.AuthorizeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AuthorizeToolStripMenuItem.Name = "AuthorizeToolStripMenuItem";
            this.AuthorizeToolStripMenuItem.Size = new System.Drawing.Size(129, 68);
            this.AuthorizeToolStripMenuItem.Text = "Yetkililer";
            this.AuthorizeToolStripMenuItem.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1317, 766);
            this.Controls.Add(this.DGVBooks);
            this.Controls.Add(this.TBSearchBook);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MemberDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BorrowBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReturnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllBorrowedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllReturnedBooksToolStripMenuItem;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ToolStripMenuItem LibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransferBookToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGVBooks;
        private System.Windows.Forms.TextBox TBSearchBook;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AuthorizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddAuthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListAuthToolStripMenuItem;
    }
}
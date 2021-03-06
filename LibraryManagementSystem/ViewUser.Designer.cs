
namespace LibraryManagementSystem
{
    partial class ViewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUser));
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TBStudentNo = new System.Windows.Forms.TextBox();
            this.LblSchoolNo = new System.Windows.Forms.Label();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.Lbhone = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TBTC = new System.Windows.Forms.TextBox();
            this.LblTC = new System.Windows.Forms.Label();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.DGVMembers = new System.Windows.Forms.DataGridView();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.LblMemberSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMembers)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Location = new System.Drawing.Point(1036, 219);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 28);
            this.BtnDelete.TabIndex = 31;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Location = new System.Drawing.Point(928, 219);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 28);
            this.BtnCancel.TabIndex = 30;
            this.BtnCancel.Text = "İptal";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Location = new System.Drawing.Point(820, 219);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 28);
            this.BtnSave.TabIndex = 29;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TBStudentNo
            // 
            this.TBStudentNo.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBStudentNo.Location = new System.Drawing.Point(773, 130);
            this.TBStudentNo.Margin = new System.Windows.Forms.Padding(4);
            this.TBStudentNo.Name = "TBStudentNo";
            this.TBStudentNo.Size = new System.Drawing.Size(397, 28);
            this.TBStudentNo.TabIndex = 27;
            this.TBStudentNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblSchoolNo
            // 
            this.LblSchoolNo.AutoSize = true;
            this.LblSchoolNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSchoolNo.Location = new System.Drawing.Point(684, 137);
            this.LblSchoolNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSchoolNo.Name = "LblSchoolNo";
            this.LblSchoolNo.Size = new System.Drawing.Size(77, 24);
            this.LblSchoolNo.TabIndex = 26;
            this.LblSchoolNo.Text = "Okul No";
            // 
            // TBPhone
            // 
            this.TBPhone.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBPhone.Location = new System.Drawing.Point(773, 97);
            this.TBPhone.Margin = new System.Windows.Forms.Padding(4);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(397, 28);
            this.TBPhone.TabIndex = 25;
            this.TBPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // Lbhone
            // 
            this.Lbhone.AutoSize = true;
            this.Lbhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbhone.Location = new System.Drawing.Point(689, 103);
            this.Lbhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbhone.Name = "Lbhone";
            this.Lbhone.Size = new System.Drawing.Size(71, 24);
            this.Lbhone.TabIndex = 24;
            this.Lbhone.Text = "Telefon";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEmail.Location = new System.Drawing.Point(704, 70);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(57, 24);
            this.LblEmail.TabIndex = 23;
            this.LblEmail.Text = "EMail";
            // 
            // TBTC
            // 
            this.TBTC.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBTC.Location = new System.Drawing.Point(195, 130);
            this.TBTC.Margin = new System.Windows.Forms.Padding(4);
            this.TBTC.Name = "TBTC";
            this.TBTC.Size = new System.Drawing.Size(397, 28);
            this.TBTC.TabIndex = 22;
            this.TBTC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTC.Location = new System.Drawing.Point(152, 137);
            this.LblTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(31, 24);
            this.LblTC.TabIndex = 21;
            this.LblTC.Text = "TC";
            // 
            // TBSurname
            // 
            this.TBSurname.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBSurname.Location = new System.Drawing.Point(195, 97);
            this.TBSurname.Margin = new System.Windows.Forms.Padding(4);
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new System.Drawing.Size(397, 28);
            this.TBSurname.TabIndex = 20;
            this.TBSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSurname.Location = new System.Drawing.Point(124, 103);
            this.LblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblSurname.Size = new System.Drawing.Size(60, 24);
            this.LblSurname.TabIndex = 19;
            this.LblSurname.Text = "Soyad";
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBName.Location = new System.Drawing.Point(195, 64);
            this.TBName.Margin = new System.Windows.Forms.Padding(4);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(397, 28);
            this.TBName.TabIndex = 18;
            this.TBName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(152, 70);
            this.LblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(33, 24);
            this.LblName.TabIndex = 17;
            this.LblName.Text = "Ad";
            // 
            // DGVMembers
            // 
            this.DGVMembers.AllowUserToAddRows = false;
            this.DGVMembers.AllowUserToDeleteRows = false;
            this.DGVMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMembers.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.DGVMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMembers.Location = new System.Drawing.Point(16, 167);
            this.DGVMembers.Margin = new System.Windows.Forms.Padding(4);
            this.DGVMembers.Name = "DGVMembers";
            this.DGVMembers.ReadOnly = true;
            this.DGVMembers.RowHeadersWidth = 51;
            this.DGVMembers.Size = new System.Drawing.Size(1289, 364);
            this.DGVMembers.TabIndex = 10;
            this.DGVMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMembers_CellClick);
            this.DGVMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMembers_CellContentClick);
            // 
            // TBSearch
            // 
            this.TBSearch.Font = new System.Drawing.Font("Calibri", 12F);
            this.TBSearch.Location = new System.Drawing.Point(507, 129);
            this.TBSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(285, 32);
            this.TBSearch.TabIndex = 8;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // LblMemberSearch
            // 
            this.LblMemberSearch.AutoSize = true;
            this.LblMemberSearch.Font = new System.Drawing.Font("Calibri", 12F);
            this.LblMemberSearch.Location = new System.Drawing.Point(420, 133);
            this.LblMemberSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMemberSearch.Name = "LblMemberSearch";
            this.LblMemberSearch.Size = new System.Drawing.Size(73, 24);
            this.LblMemberSearch.TabIndex = 7;
            this.LblMemberSearch.Text = "Üye TC ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(731, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üyeleri Görüntüle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.TBEmail);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.TBStudentNo);
            this.panel2.Controls.Add(this.LblSchoolNo);
            this.panel2.Controls.Add(this.TBPhone);
            this.panel2.Controls.Add(this.Lbhone);
            this.panel2.Controls.Add(this.LblEmail);
            this.panel2.Controls.Add(this.TBTC);
            this.panel2.Controls.Add(this.LblTC);
            this.panel2.Controls.Add(this.TBSurname);
            this.panel2.Controls.Add(this.LblSurname);
            this.panel2.Controls.Add(this.TBName);
            this.panel2.Controls.Add(this.LblName);
            this.panel2.Location = new System.Drawing.Point(16, 539);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1289, 319);
            this.panel2.TabIndex = 11;
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBEmail.Location = new System.Drawing.Point(773, 64);
            this.TBEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(397, 28);
            this.TBEmail.TabIndex = 23;
            this.TBEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 123);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(551, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
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
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1344, 661);
            this.Controls.Add(this.DGVMembers);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.LblMemberSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üyeleri Görüntüle";
            this.Load += new System.EventHandler(this.ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMembers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TBStudentNo;
        private System.Windows.Forms.Label LblSchoolNo;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.Label Lbhone;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TBTC;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.TextBox TBSurname;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.DataGridView DGVMembers;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Label LblMemberSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}
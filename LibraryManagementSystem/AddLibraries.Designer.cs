
namespace LibraryManagementSystem
{
    partial class AddLibraries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLibraries));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TBLocation = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblAddStudent = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.BtnReset);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.TBLocation);
            this.panel2.Controls.Add(this.LblPrice);
            this.panel2.Controls.Add(this.TBName);
            this.panel2.Controls.Add(this.LblName);
            this.panel2.Location = new System.Drawing.Point(258, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 323);
            this.panel2.TabIndex = 11;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.Location = new System.Drawing.Point(314, 207);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 22;
            this.BtnReset.Text = "Sıfırla";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Location = new System.Drawing.Point(233, 207);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TBLocation
            // 
            this.TBLocation.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBLocation.Location = new System.Drawing.Point(111, 112);
            this.TBLocation.Name = "TBLocation";
            this.TBLocation.Size = new System.Drawing.Size(278, 24);
            this.TBLocation.TabIndex = 9;
            this.TBLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPrice.Location = new System.Drawing.Point(52, 117);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(53, 19);
            this.LblPrice.TabIndex = 8;
            this.LblPrice.Text = "Konum";
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Calibri", 10F);
            this.TBName.Location = new System.Drawing.Point(111, 82);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(278, 24);
            this.TBName.TabIndex = 1;
            this.TBName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(79, 87);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(26, 19);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Ad";
            // 
            // LblAddStudent
            // 
            this.LblAddStudent.AutoSize = true;
            this.LblAddStudent.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAddStudent.Location = new System.Drawing.Point(94, 33);
            this.LblAddStudent.Name = "LblAddStudent";
            this.LblAddStudent.Size = new System.Drawing.Size(143, 24);
            this.LblAddStudent.TabIndex = 1;
            this.LblAddStudent.Text = "Kütüphane Ekle";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.LblAddStudent);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 85);
            this.panel1.TabIndex = 10;
            // 
            // AddLibraries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(684, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddLibraries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Ekle";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TBLocation;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblAddStudent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hesabınızdan Çıkış Yapmak İstediğinize Emin misiniz ? ","Onayla",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                LibraryToolStripMenuItem.Visible = false;
                AuthorizeToolStripMenuItem.Visible = false;
                kitaplarToolStripMenuItem.Visible = false;
                AddNewBookToolStripMenuItem.Visible = false;
                AllBorrowedBooksToolStripMenuItem.Visible = false;
                ReturnBookToolStripMenuItem.Visible = false;
                MemberToolStripMenuItem.Visible = false;
                BorrowBookToolStripMenuItem.Visible = false;
                AllReturnedBooksToolStripMenuItem.Visible = false;
                TransferBookToolStripMenuItem.Visible = false;
                Login.Role = "";
                Login.LibID = "";
                Login obj = new Login();
                this.Hide();
                obj.Show();
            }
        }

        private void AddNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks obj = new AddBooks();
            obj.Show();
        }

      

        private void ViewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooks obj = new ViewBooks();
            obj.Show();
        }

        private void AddMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser obj = new AddUser();
            obj.Show();
        }


        private void BorrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowBook obj = new BorrowBook();
            obj.Show();
        }

        private void ReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook obj = new ReturnBook();
            obj.Show();
        }

        private void AllBorrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllBorrowedBooks obj = new AllBorrowedBooks();
            obj.Show();
        }

        private void AllReturnedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllReturnedBook obj = new AllReturnedBook();
            obj.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış Yapmak İstediğinize Emin misiniz ? ", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            if (Login.Role == "Admin")
            {
                LibraryToolStripMenuItem.Visible = true;
                AuthorizeToolStripMenuItem.Visible = true;
                kitaplarToolStripMenuItem.Visible = true;
                TransferBookToolStripMenuItem.Visible = true;
                AddNewBookToolStripMenuItem.Visible = true;
            }
            else if (Login.Role == "Stok Sorumlusu")
            {
                kitaplarToolStripMenuItem.Visible = true;
                AddNewBookToolStripMenuItem.Visible = false;
                AllBorrowedBooksToolStripMenuItem.Visible = true;
                AllReturnedBooksToolStripMenuItem.Visible = true;
                TransferBookToolStripMenuItem.Visible = false;
            }
            else if (Login.Role == "Memur")
            {
                MemberToolStripMenuItem.Visible = true;
                BorrowBookToolStripMenuItem.Visible = true;
                ReturnBookToolStripMenuItem.Visible = true;
                TransferBookToolStripMenuItem.Visible = false;
            }
        }
        private void TransferBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferBooks obj = new TransferBooks();
            obj.Show();
        }

        private void AddAuthToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddAuthorized obj = new AddAuthorized();
            obj.Show();
        }

        private void ListAuthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAuthorizer obj = new ViewAuthorizer();
            obj.Show();
        }

        private void ListLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ViewLibraries obj = new ViewLibraries();
            obj.Show();
        }

        private void AddLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddLibraries obj = new AddLibraries();
            obj.Show();
        }

        private void MemberDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ViewUser obj = new ViewUser();
            obj.Show();
        }
    }
}

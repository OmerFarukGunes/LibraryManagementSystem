using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = ("Select * from BookTbl");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGVBooks.DataSource = ds.Tables[0];
            con.Close();
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
                TBSearchBook.Visible = true;
                DGVBooks.Visible = true;
                LoginToolStripMenuItem.Visible = true;
                ExitToolStripMenuItem.Visible = false;
                Login.Role = "";
                Login.LibID = "";
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
                AddNewBookToolStripMenuItem.Visible = true;
                TransferBookToolStripMenuItem.Visible = false;
                ExitToolStripMenuItem.Visible = true;
                TBSearchBook.Visible = false;
                DGVBooks.Visible = false;
                LoginToolStripMenuItem.Visible = false;
            }
            else if (Login.Role == "Stok Sorumlusu")
            {
                TransferBookToolStripMenuItem.Visible = true;
                kitaplarToolStripMenuItem.Visible = true;
                AddNewBookToolStripMenuItem.Visible = false;
                AllBorrowedBooksToolStripMenuItem.Visible = true;
                AllReturnedBooksToolStripMenuItem.Visible = true;
                TransferBookToolStripMenuItem.Visible = true;
                ExitToolStripMenuItem.Visible = true;
                TBSearchBook.Visible = false;
                DGVBooks.Visible = false;
                LoginToolStripMenuItem.Visible = false;
            }
            else if (Login.Role == "Memur")
            {
                MemberToolStripMenuItem.Visible = true;
                BorrowBookToolStripMenuItem.Visible = true;
                ReturnBookToolStripMenuItem.Visible = true;
                TransferBookToolStripMenuItem.Visible = false;
                ExitToolStripMenuItem.Visible = true;
                TBSearchBook.Visible = false;
                DGVBooks.Visible = false;
                LoginToolStripMenuItem.Visible = false;
            }
            else
            {
                TBSearchBook.Visible = true;
                DGVBooks.Visible = true;
                LoginToolStripMenuItem.Visible = true;
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

        private void TBSearchBook_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            if (TBSearchBook.Text != "")
            {
                cmd.CommandText = ("Select * from BookTbl where BookName LIKE '" + TBSearchBook.Text + "%'");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVBooks.DataSource = ds.Tables[0];
            }
            else
            {
                cmd.CommandText = ("Select * from BookTbl");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVBooks.DataSource = ds.Tables[0];
            }
            con.Close();
        }

        private void LoginToolStripMenuItem_Click_1(object sender, EventArgs e)
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
            TBSearchBook.Visible = false;
            DGVBooks.Visible = false;
            LoginToolStripMenuItem.Visible = false;
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }
    }
}

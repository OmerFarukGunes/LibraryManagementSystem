using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AllReturnedBook : Form
    {
        public AllReturnedBook()
        {
            InitializeComponent();
        }

        private void AllReturnedBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = ("Select * from BorrowedBookTbl where BookReturnDate is not null AND LibraryID = "+Login.LibID+"");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGVBooks.DataSource = ds.Tables[0];

            con.Close();
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

                cmd.CommandText = ("Select * from BorrowedBookTbl where (UserNo LIKE '" + TBSearchBook.Text + "%' OR BookName LIKE '" + TBSearchBook.Text + "%'  OR UserEmail LIKE '" + TBSearchBook.Text + "%' OR BookIssueDate LIKE '" + TBSearchBook.Text + "%') AND BookReturnDate is not null AND LibraryID = " + Login.LibID + "");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVBooks.DataSource = ds.Tables[0];
            }
            else
            {
                cmd.CommandText = ("Select * from BorrowedBookTbl where BookReturnDate is not null AND LibraryID = " + Login.LibID + "");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVBooks.DataSource = ds.Tables[0];
            }

            con.Close();
        }
    }
}

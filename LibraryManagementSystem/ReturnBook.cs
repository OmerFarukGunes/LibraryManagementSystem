using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

       
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TBSearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "Select * from BorrowedBookTbl where UserNo = " + TBSearch.Text + " and BookReturnDate is null AND LibraryID = " + Login.LibID + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                DGVBooks.DataSource = DS.Tables[0];
                con.Close();
            }
        }
        string bookID;
        private void DGVBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bookID = DGVBooks.Rows[e.RowIndex].Cells[0].Value.ToString();
                TBBookName.Text = DGVBooks.Rows[e.RowIndex].Cells[7].Value.ToString();
                TBPrice.Text = DGVBooks.Rows[e.RowIndex].Cells[10].Value.ToString();
                TBTC.Text = DGVBooks.Rows[e.RowIndex].Cells[1].Value.ToString();
                DTPPublish.Value = DateTime.Parse(DGVBooks.Rows[e.RowIndex].Cells[8].Value.ToString());
                panel2.Visible = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Veri Güncellenecek Onaylıyor musunuz ?", "Başarılı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = ("update BorrowedBookTbl set BookReturnDate='" + DTPReturnDate.Text + "', LibraryID ='"+Login.LibID+"' where UserNo=" + TBTC.Text + " And BookName = '"+TBBookName.Text+ "' And BookPrice = " + TBPrice.Text + "");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.CommandText = ("UPDATE ConnectionTbl SET Stock= Stock + 1 WHERE BookID=" + bookID + " AND LibraryID ="+Login.LibID+"");
                cmd.ExecuteNonQuery();
                panel2.Visible = false;
                BtnSearch_Click("obj", EventArgs.Empty);
            }
        }

        private void EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSave_Click("obj", EventArgs.Empty);
            }
        }
    }
}

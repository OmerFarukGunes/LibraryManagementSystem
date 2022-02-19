using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }

        StringBuilder Books = new StringBuilder();
        private void ViewBooks_Load(object sender, EventArgs e)
        { 
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            if (Login.Role != "Admin")
            {
                cmd.CommandText = ("Select * from W_LocalView where LibraryID =" + Login.LibID + "");
            }
            else
            {
                cmd.CommandText = ("Select * from BookTbl");
            }
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGVBooks.DataSource = ds.Tables[0];
              
        }

        int bookId;
        private void DGVBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null && Login.Role=="Admin")
            {
                bookId = int.Parse(DGVBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(DGVBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
                panel2.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = ("Select * from BookTbl where BookID ="+bookId+"");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                TBBookName.Text = ds.Tables[0].Rows[0][1].ToString();
                TBBookAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
                TBPublication.Text = ds.Tables[0].Rows[0][3].ToString();
                DTPPublish.Text = DateTime.Parse( ds.Tables[0].Rows[0][4].ToString()).ToString();
                TBPrice.Text = ds.Tables[0].Rows[0][5].ToString();
                TBStock.Text = ds.Tables[0].Rows[0][6].ToString();

                con.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TBBookAuthor.Text != "" && TBBookName.Text != "" && TBPrice.Text != "" && TBPublication.Text != "" && TBStock.Text != "" && IsAlpha() && IsNumberic())
            {
                if (MessageBox.Show("Veri Güncellenecek Onaylıyor musunuz ?", "Başarılı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = ("update BookTbl set BookName='" + TBBookName.Text + "',BookAuthor='" + TBBookAuthor.Text + "',BookPublication='" + TBPublication.Text + "',BookPublishDate='" + DateTime.Parse(DTPPublish.Text) + "',BookQuantity=" + TBStock.Text + ",BookPrice=" + TBPrice.Text + " where BookId=" + bookId + "");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    panel2.Visible = false;

                    ViewBooks_Load("obj", EventArgs.Empty);
                }
            }
            else
            {
                MessageBox.Show("Eksik Veya Hatalı Girdi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void TBSearchBook_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            if (TBSearchBook.Text!="" &&Login.Role== "Stok Sorumlusu")
            {
                cmd.CommandText = ("Select * from BookTbl where BookName LIKE '" + TBSearchBook.Text + "%' AND BookID in (" + Books + ")");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVBooks.DataSource = ds.Tables[0];
            }
            else if(Login.Role == "Stok Sorumlusu")
            {
                cmd.CommandText = ("Select * from BookTbl where BookID in (" + Books + ")");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVBooks.DataSource = ds.Tables[0];
            }
            else if(TBSearchBook.Text != "" && Login.Role == "Admin")
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Veri Silinecek Onaylıyor musunuz ?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = ("Delete From BookTbl where BookId="+bookId+"");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                panel2.Visible = false;

                ViewBooks_Load("obj", EventArgs.Empty);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            TBSearchBook.Clear();
            panel2.Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private bool IsAlpha()
        {
            string pattern = "^[a-zA-Z ]";
            if (Regex.IsMatch(TBBookAuthor.Text, pattern))
            {
                errorProvider1.Clear();
                return true;
            }
            else
            {
                errorProvider1.SetError(TBBookAuthor, "geçerli bir isim giriniz");
                return false;
            }


        }
        private bool IsNumberic()
        {
            string pattern = "^[0-9]";
            if (Regex.IsMatch(TBStock.Text, pattern) && Regex.IsMatch(TBPrice.Text, pattern))
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                return true;
            }
            else if (!Regex.IsMatch(TBStock.Text, pattern) && !Regex.IsMatch(TBPrice.Text, pattern))
            {
                errorProvider2.SetError(TBPrice, "geçerli bir değer giriniz");
                errorProvider1.SetError(TBStock, "geçerli bir değer giriniz");
                return false;
            }
            else if (!Regex.IsMatch(TBPrice.Text, pattern))
            {
                errorProvider2.SetError(TBPrice, "geçerli bir değer giriniz");
                return false;
            }
            else
            {
                errorProvider1.SetError(TBStock, "geçerli bir değer giriniz");
                return false;
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

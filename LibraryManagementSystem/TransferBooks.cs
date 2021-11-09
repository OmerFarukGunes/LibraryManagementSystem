using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class TransferBooks : Form
    {
        public TransferBooks()
        {
            InitializeComponent();
        }

        long ConId = 0;
        private void TransferBooks_Load(object sender, EventArgs e)
        {  
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = ("Select * from BookTbl where BookQuantity>0");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGVBooks.DataSource = ds.Tables[0];
            cmd = new SqlCommand("Select STR(LibraryID) +' ;' +LibraryName from LibraryTbl", con);
            SqlDataReader sdr = cmd.ExecuteReader(); 
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    CBLibraries.Items.Add(sdr[i]);
                }
            }
            sdr.Close();
            con.Close();
        }
        long stock = 0;
        private void CBLibraries_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DGVBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBBookName.Text = DGVBooks.Rows[e.RowIndex].Cells[1].Value.ToString();
            TBBookID.Text = DGVBooks.Rows[e.RowIndex].Cells[0].Value.ToString();
            stock = long.Parse(DGVBooks.Rows[e.RowIndex].Cells[5].Value.ToString());
            panel2.Visible = true;
        }
        long LibraryID = 0;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(long.Parse(TBStock.Text) <= stock && IsNumberic())
            {
                if (MessageBox.Show("Transferi Onaylıyor musunuz ?", "Başarılı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    LibraryID = long.Parse(CBLibraries.Text.Split(';')[0].Trim());
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = ("Select ConnectionID from ConnectionTbl where BookID = " + TBBookID.Text + " AND LibraryID = " + LibraryID + "");
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    if (dataSet.Tables[0].Rows.Count > 0)
                    {

                        ConId = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
                        cmd.CommandText = ("update ConnectionTbl set Stock = Stock +" + TBStock.Text + " where ConnectionID=" + ConId + "");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        cmd.CommandText = ("update BookTbl set BookQuantity = BookQuantity -" + TBStock.Text + " where BookID=" + TBBookID.Text + "");
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        cmd.CommandText = "insert into ConnectionTbl (LibraryID,BookID,Stock) values(" + LibraryID + "," + TBBookID.Text + "," + TBStock.Text + ")";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = ("update BookTbl set BookQuantity = BookQuantity -" + TBStock.Text + " where BookID=" + TBBookID.Text + "");
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();

                    panel2.Visible = false;
                    TransferBooks_Load("obj", EventArgs.Empty);
                }
            }
            else if(long.Parse(TBStock.Text) <= stock)
            {
                MessageBox.Show("Yetersiz Stok", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik veya Hatalı Girdi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                cmd.CommandText = ("Select * from BooksTbl where BookName LIKE '" + TBSearchBook.Text + "%'");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVBooks.DataSource = ds.Tables[0];
            }
            else
            {
                cmd.CommandText = ("Select * from BooksTbl");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVBooks.DataSource = ds.Tables[0];
            }

            con.Close();
        }
        private bool IsNumberic()
        {
            string pattern = "^[0-9]";
            if (Regex.IsMatch(TBStock.Text, pattern))
            {
                errorProvider1.Clear();
                return true;
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}

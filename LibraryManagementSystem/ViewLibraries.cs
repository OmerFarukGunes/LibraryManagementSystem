using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ViewLibraries : Form
    {
        public ViewLibraries()
        {
            InitializeComponent();
        }
        int libId = 0;
        private void ViewLibraries_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = ("Select * from LibraryTbl");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGVULibrary.DataSource = ds.Tables[0];
            con.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(TBName.Text != "" && TBLocation.Text != "")
            {
                if (MessageBox.Show("Veri Güncellenecek Onaylıyor musunuz ?", "Başarılı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = ("update LibraryTbl set LibraryName='" + TBName.Text + "',LibraryLocation='" + TBLocation.Text + "' where LibraryID=" + libId + "");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    panel2.Visible = false;

                    ViewLibraries_Load("obj", EventArgs.Empty);
                }
            }
           
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
                cmd.CommandText = ("Delete From LibraryTbl where LibraryID=" + libId + "");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                panel2.Visible = false;

                ViewLibraries_Load("obj", EventArgs.Empty);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void DGVULibrary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            libId = int.Parse(DGVULibrary.Rows[e.RowIndex].Cells[0].Value.ToString());
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = ("Select * from LibraryTbl where LibraryID =" + libId + "");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            TBName.Text = ds.Tables[0].Rows[0][1].ToString();
            TBLocation.Text = ds.Tables[0].Rows[0][2].ToString();

            con.Close();
        }

        private void TBSearchBook_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            if (TBSearchBook.Text != "" && Login.Role == "Admin")
            {
                cmd.CommandText = ("Select * from LibraryTbl where LibraryName LIKE '" + TBSearchBook.Text + "%'");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVULibrary.DataSource = ds.Tables[0];
            }
            else
            {
                cmd.CommandText = ("Select * from LibraryTbl");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVULibrary.DataSource = ds.Tables[0];
            }

            con.Close();
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

using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ViewAuthorizer : Form
    {
        public ViewAuthorizer()
        {
            InitializeComponent();
        }

        private void ViewLibraries_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = ("Select * from LoginTbl");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            DGVUser.DataSource = ds.Tables[0];
            DGVUser.Columns.Remove("Password");
            CBAuthorizeType.Items.Add("Admin");
            CBAuthorizeType.Items.Add("Stok Sorumlusu");
            CBAuthorizeType.Items.Add("Memur");
           
            con.Close();
        }
        int UserId = 0;
        private void DGVUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserId = int.Parse(DGVUser.Rows[e.RowIndex].Cells[0].Value.ToString());
            panel2.Visible = true;

            TBName.Text = DGVUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            TBEmail.Text = DGVUser.Rows[e.RowIndex].Cells[2].Value.ToString();
            CBAuthorizeType.Text = DGVUser.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {   
            if(TBName.Text != "" && TBEmail.Text != "" && Email_validation() && AlphabeticChar())
            {
                    if (MessageBox.Show("Veri Güncellenecek Onaylıyor musunuz ?", "Başarılı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        con.Open();
                        cmd.CommandText = ("update LoginTbl set UserName='" + TBName.Text + "',Email='" + TBEmail.Text + "',Type='" + CBAuthorizeType.Text + "' where ID=" + UserId + "");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        panel2.Visible = false;

                        ViewLibraries_Load("obj", EventArgs.Empty);
                   
                }
                else
                {
                    MessageBox.Show("Kayıtlı Email Adresi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eksik Veya Hatalı Değer", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.CommandText = ("Delete From LoginTbl where ID=" + UserId + "");
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

        private void TBSearchBook_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            if (TBSearchBook.Text != "" && Login.Role == "Admin")
            {
                cmd.CommandText = ("Select * from BooksTbl where Email LIKE '" + TBSearchBook.Text + "%'");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVUser.DataSource = ds.Tables[0];
            }
            else
            {
                cmd.CommandText = ("Select * from BooksTbl");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVUser.DataSource = ds.Tables[0];
            }

            con.Close();
        }
        private bool Email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
               + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
               + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            if (Regex.IsMatch(TBEmail.Text, pattern))
            {
                errorProvider1.Clear();
                return true;
            }
            else
            {
                errorProvider1.SetError(TBEmail, "geçerli bir email adresi giriniz");
                return false;
            }
        }
        private bool AlphabeticChar()
        {
            string pattern = "^[a-zA-Z ]";
            if (Regex.IsMatch(TBName.Text, pattern))
            {
                errorProvider2.Clear();
                return true;
            }
            else
            {
                errorProvider2.SetError(TBName, "geçerli bir isim giriniz");
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

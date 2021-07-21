using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ViewUser : Form
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = ("Select * from UserTbl");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGVMembers.DataSource = ds.Tables[0];

            con.Close();
        }

        int UserId;
        private void DGVMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DGVMembers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals(null))
            {
                UserId = int.Parse(DGVMembers.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(DGVBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
                panel2.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = ("Select * from UserTbl where UserID =" + UserId + "");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                TBName.Text = ds.Tables[0].Rows[0][1].ToString();
                TBSurname.Text = ds.Tables[0].Rows[0][2].ToString();
                TBTC.Text = ds.Tables[0].Rows[0][3].ToString();
                TBEmail.Text = ds.Tables[0].Rows[0][4].ToString();
                TBPhone.Text = ds.Tables[0].Rows[0][5].ToString();
                TBStudentNo.Text = ds.Tables[0].Rows[0][6].ToString();

                con.Close();
            }
        }
        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            if (TBSearch.Text != "")
            {

                cmd.CommandText = ("Select * from UserTbl where UserNo LIKE '" + TBSearch.Text + "%'");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVMembers.DataSource = ds.Tables[0];
            }
            else
            {
                cmd.CommandText = ("Select * from UserTbl");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DGVMembers.DataSource = ds.Tables[0];
            }

            con.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TBName.Text != "" && TBSurname.Text != "" && TBEmail.Text != "" && TBPhone.Text != "" && TBTC.Text != "" &&Email_validation()&&IsTC()&&IsNumberic()&&IsAlpha()&&IsPhone())
            {
                    if (MessageBox.Show("Veri Güncellenecek Onaylıyor musunuz ?", "Başarılı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        con.Open();
                        cmd.CommandText = ("update UserTbl set UserName='" + TBName.Text + "',UserSurname='" + TBSurname.Text + "',UserNo='" + TBTC.Text + "',UserEmail='" + TBEmail.Text + "',UserPhone=" + TBPhone.Text + ",StudentNo='" + TBStudentNo.Text + "' where UserId=" + UserId + "");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        panel2.Visible = false;

                        ViewUser_Load("obj", EventArgs.Empty);
                    }

                    else
                    {
                        MessageBox.Show("Aynı TC No Tekrar Kayıt Edilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.CommandText = ("Delete From UserTbl where UserId=" + UserId + "");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                panel2.Visible = false;

                ViewUser_Load("obj", EventArgs.Empty);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        private bool IsAlpha()
        {
            string pattern = "^[a-zA-Z ]";
            if (Regex.IsMatch(TBName.Text, pattern) && Regex.IsMatch(TBSurname.Text, pattern))
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                return true;
            }
            else if (!Regex.IsMatch(TBName.Text, pattern) && !Regex.IsMatch(TBSurname.Text, pattern))
            {
                errorProvider2.SetError(TBSurname, "geçerli bir isim giriniz");
                errorProvider1.SetError(TBName, "geçerli bir isim giriniz");
                return false;
            }
            else if (!Regex.IsMatch(TBName.Text, pattern))
            {

                errorProvider1.SetError(TBName, "geçerli bir isim giriniz");
                return false;
            }
            else
            {
                errorProvider2.SetError(TBSurname, "geçerli bir isim giriniz");
                return false;
            }


        }
        private bool IsNumberic()
        {
            string pattern = "^[0-9]";
            if (Regex.IsMatch(TBStudentNo.Text, pattern))
            {
                errorProvider3.Clear();
                return true;
            }
            else
            {
                errorProvider3.SetError(TBStudentNo, "geçerli bir değer giriniz");
                return false;
            }
        }
        private bool Email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
               + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
               + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            if (Regex.IsMatch(TBEmail.Text, pattern))
            {
                errorProvider6.Clear();
                return true;
            }
            else
            {
                errorProvider6.SetError(TBEmail, "geçerli bir email adresi giriniz");
                return false;
            }
        }
        private bool IsTC()
        {
            string pattern = (@"^([0-9]{4})\s?([0-9]{4})\s?([0-9]{4})\s?([0-9]{4})$");
            if (Regex.IsMatch(TBTC.Text, pattern))
            {
                errorProvider4.Clear();
                return true;
            }
            else
            {
                errorProvider4.SetError(TBTC, "geçerli bir değer giriniz");
                return false;
            }
        }
        private bool IsPhone()
        {
            string pattern = @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$";
            if (Regex.IsMatch(TBPhone.Text, pattern))
            {
                errorProvider5.Clear();
                return true;
            }
            else
            {
                errorProvider5.SetError(TBPhone, "geçerli bir değer giriniz");
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

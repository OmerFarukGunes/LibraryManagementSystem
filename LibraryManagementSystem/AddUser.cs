using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TBName.Text != "" && TBSurname.Text != "" && TBEmail.Text != "" && TBPhone.Text != "" && TBTC.Text != "" && Email_validation() && IsTC() && IsNumberic() && IsAlpha() && IsPhone())
            {
                if (DBTCChecked())
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "insert into UserTbl (UserName,UserSurname,UserNo,UserEmail,UserPhone,StudentNo) values('" + TBName.Text + "','" + TBSurname.Text + "'," + TBTC.Text + ",'" + TBEmail.Text + "','" + TBPhone.Text + "','" + TBStudentNo.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Veri Kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBName.Clear();
                    TBSurname.Clear();
                    TBEmail.Clear();
                    TBPhone.Clear();
                    TBTC.Clear();
                    TBStudentNo.ResetText();
                }
                else
                {
                    MessageBox.Show("Aynı Kişi Tekrar Kayıt Edilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("Eksik Veya Hatalı Değer", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TBName.Clear();
            TBSurname.Clear();
            TBEmail.Clear();
            TBPhone.Clear();
            TBTC.Clear();
            TBStudentNo.ResetText();
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
            string pattern = (@"^[1-9]{1}[0-9]{9}[02468]{1}$");
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
            return true;
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
        private bool DBTCChecked()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";

            SqlCommand cmd = new SqlCommand("Select count(*) from UserTbl where UserNo= @UserNo", con);
            cmd.Parameters.AddWithValue("@UserNo", TBTC.Text);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            if (TotalRows > 0)
                return false;
            return true;
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

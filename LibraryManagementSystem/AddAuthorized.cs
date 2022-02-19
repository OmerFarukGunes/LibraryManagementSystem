using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace LibraryManagementSystem
{
    public partial class AddAuthorized : Form
    {
        public AddAuthorized()
        {
            InitializeComponent();
        }

        string password { get; set; }

        long LibraryID = 0;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TBName.Text != "" && TBEmail.Text != "" && TBPassword.Text != "" && (Email_validation() && AlphabeticChar()))
            {
                if (DBEmailChecked())
                {
                    password = Encrypt(TBPassword.Text);
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    if (CBAuthorizeType.Text == "Admin")
                        cmd.CommandText = "insert into LoginTbl (UserName,Password,Email,Type,LibraryID) values('" + TBName.Text + "','" + password + "','" + TBEmail.Text + "','" + CBAuthorizeType.Text + "'," + 0.ToString() + ")";
                    else
                    {
                        LibraryID = long.Parse(CBLibraries.Text.Split(';')[0].Trim());
                        cmd.CommandText = "insert into LoginTbl (UserName,Password,Email,Type,LibraryID) values('" + TBName.Text + "','" + password + "','" + TBEmail.Text + "','" + CBAuthorizeType.Text + "'," + LibraryID + ")";

                    }

                    cmd.ExecuteNonQuery();
                    con.Close();
                    SendMail(TBEmail.Text);
                    MessageBox.Show("Veri Kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
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

        private void AddAuthorized_Load(object sender, EventArgs e)
        {
            CBAuthorizeType.Items.Add("Admin");
            CBAuthorizeType.Items.Add("Stok Sorumlusu");
            CBAuthorizeType.Items.Add("Memur");
            SqlConnection con = new SqlConnection();
            SqlCommand cmd;
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            con.Open();
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

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TBName.Clear();
            TBEmail.Clear();
            TBPassword.Clear();
            CBAuthorizeType.SelectedIndex = -1;
            CBLibraries.SelectedIndex = -1;
        }
        private void SendMail(string email)
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("kariyerportali.bmo@gmail.com", "kariyerportali.2020");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("kariyerportali.bmo@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Sisteme Kaydınız Tamamlanmıştır";
            mail.IsBodyHtml = false;
            mail.Body = "Şifreniz : " + TBPassword.Text + " Kullanıcı Adınız : " + TBName.Text;
            smtpClient.Send(mail);
            TBName.Clear();
            TBEmail.Clear();
            TBPassword.Clear();
            CBAuthorizeType.SelectedIndex = -1;
        }
        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
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
        private bool DBEmailChecked()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";           
            SqlCommand cmd = new SqlCommand("Select count(*) from LoginTbl where Email= @email", con);
            cmd.Parameters.AddWithValue("@email", this.TBEmail.Text);
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

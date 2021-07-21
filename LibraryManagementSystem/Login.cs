using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string Role = "";
        public static string LibID = "";
        private void TBUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (TBUserName.Text == "Kullanıcı Adı")
            {
                TBUserName.Clear();
            }
        }

        private void TBPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (TBUserName.Text == "Şifre")
            {
                TBPassword.Clear();
                TBPassword.PasswordChar = '*';
            }
        }

        private void PBWebLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://e-maarif.org/");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string pass = "";
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            pass = Encrypt(TBPassword.Text);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from LoginTbl where UserName ='"+TBUserName.Text+"' and Password ='"+ pass + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count !=0)
            {
                Role = ds.Tables[0].Rows[0][4].ToString();
                LibID =ds.Tables[0].Rows[0][5].ToString();
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Girdi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        static string Encrypt(string value)
        {
            //Using MD5 to encrypt a string
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                //Hash data
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        private void TBUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_MouseHover(object sender, EventArgs e)
        {
            TBPassword.PasswordChar = '\0';
        }

        private void Show_MouseLeave(object sender, EventArgs e)
        {
            TBPassword.PasswordChar = '*';
        }

        private void TBPassword_Enter(object sender, EventArgs e)
        {
            BtnLogin_Click("obj", EventArgs.Empty);
        }

        private void EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click("obj", EventArgs.Empty);
            }
        }
    }
}

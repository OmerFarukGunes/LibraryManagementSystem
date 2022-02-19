using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TBBookAuthor.Text != "" && TBBookName.Text != "" && TBPrice.Text != "" && TBPublication.Text != "" && TBStock.Text != "" && IsAlpha()&&IsNumberic())
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into BookTbl (BookName,BookAuthor,BookPublication,BookPublishDate,BookQuantity,BookPrice) values('" + TBBookName.Text + "','" + TBBookAuthor.Text + "','" + TBPublication.Text + "','" + DateTime.Parse(DTPPublish.Text) + "'," + TBStock.Text + "," + TBPrice.Text + ")";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Veri Kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBBookAuthor.Clear();
                TBBookName.Clear();
                TBPrice.Clear();
                TBPublication.Clear();
                TBStock.Clear();
                DTPPublish.ResetText();
            }
            else
            {
                MessageBox.Show("Eksik Veya Hatalı Girdi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TBBookAuthor.Clear();
            TBBookName.Clear();
            TBPrice.Clear();
            TBPublication.Clear();
            TBStock.Clear();
            DTPPublish.ResetText();
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
            else if(!Regex.IsMatch(TBPrice.Text, pattern))
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

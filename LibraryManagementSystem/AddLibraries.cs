using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddLibraries : Form
    {
        public AddLibraries()
        {
            InitializeComponent();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TBName.Text != "" && TBLocation.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into LibraryTbl (LibraryName,LibraryLocation) values('" + TBName.Text + "','" + TBLocation.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Veri Kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBName.Clear();
                TBLocation.Clear();
            }
            else
            {
                MessageBox.Show("Eksik Değer", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İptal Etmek İstediğinize Emin misiniz ? Kayıtlı olmayan veriler silinecektir ", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
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

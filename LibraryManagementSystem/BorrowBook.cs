using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BorrowBook : Form
    {
        public BorrowBook()
        {
            InitializeComponent();
        }

        StringBuilder books = new StringBuilder();
        private void BorrowBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = ("Select BookID from ConnectionTbl where LibraryID = " + Login.LibID + "");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSource = new DataSet();
            dataAdapter.Fill(dataSource);
            for (int i = 0; i < dataSource.Tables[0].Rows.Count; i++)
            {
                if (i == dataSource.Tables[0].Rows.Count - 1)
                    books.Append(dataSource.Tables[0].Rows[i][0].ToString());
                else
                    books.Append(dataSource.Tables[0].Rows[i][0].ToString() + ",");
            }
            cmd.CommandText = ("Select STR(BookID) +' ;' + BookName from BookTbl where BookID in (" + books + ") AND BookQuantity > 0");
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    CBBookName.Items.Add(sdr[i]);
                }
            }
            sdr.Close();
            con.Close();
        }
        int count=0;
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TBSearch.Text!="")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "Select * from UserTbl where UserNo = " + TBSearch.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                cmd.CommandText = "select count(UserNo) from BorrowedBookTbl where UserNo = " + TBSearch.Text + " and BookReturnDate is null";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                count = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());

                if (DS.Tables[0].Rows.Count!=0)
                {
                    TBName.Text = DS.Tables[0].Rows[0][1].ToString();
                    TBSurname.Text = DS.Tables[0].Rows[0][6].ToString();
                    TBTC.Text = DS.Tables[0].Rows[0][2].ToString();
                    TBEmail.Text = DS.Tables[0].Rows[0][3].ToString();
                    TBPhone.Text = DS.Tables[0].Rows[0][4].ToString();
                    TBStudentNo.Text = DS.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    TBName.Clear();
                    TBSurname.Clear();
                    TBPhone.Clear();
                    TBSearch.Clear();
                    TBStudentNo.Clear();
                    TBTC.Clear();
                    TBEmail.Clear();
                    MessageBox.Show("Üye Bilgisi Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        long bookID = 0;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TBName.Text!=""&& CBBookName.SelectedIndex!=-1 && count<=2)
            {
                bookID = long.Parse(CBBookName.Text.Split(';')[0].Trim());
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                string a = TBPrice.Text.Replace(" ₺", "");
                cmd.CommandText = "insert into dbo.BorrowedBookTbl (UserNo,UserName,UserSurname,UserEmail,UserPhone,UserStudentNo,BookName,BookIssueDate,BookPrice,LibraryID) values(" + TBTC.Text + ",'" + TBName.Text + "','" + TBSurname.Text + "','" + TBEmail.Text + "','" + TBPhone.Text + "','" + TBStudentNo.Text + "','" + CBBookName.Text + "','" + DTPBorrowDate.Text + "'," + a + "," + Login.LibID + ")";
                cmd.ExecuteNonQuery();
                cmd.CommandText = ("UPDATE ConnectionTbl SET Stock= Stock - 1 WHERE BookID=" + bookID + " AND LibraryID =" + Login.LibID + "");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Veri Kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprm", 285, 600);
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                TBName.Clear();
                TBSurname.Clear();
                TBEmail.Clear();
                TBPhone.Clear();
                TBTC.Clear();
                TBStudentNo.Clear();
                CBBookName.SelectedItem = -1;
                TBStudentNo.ResetText();
              
                BorrowBook_Load("obj", EventArgs.Empty);
                con.Close();
            }
            else if(count>=2)
            {
                MessageBox.Show("Kisi 3 ten fazla kitap alamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik veya Yanlış girdi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TBName.Clear();
            TBSurname.Clear();
            TBEmail.Clear();
            TBPhone.Clear();
            TBTC.Clear();
            TBStudentNo.Clear();
            CBBookName.SelectedIndex = -1;
            TBStudentNo.ResetText();
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            if (TBSearch.Text=="")
            {
                TBName.Clear();
                TBSurname.Clear();
                TBEmail.Clear();
                TBPhone.Clear();
                TBTC.Clear();
                TBStudentNo.Clear();
                CBBookName.SelectedIndex = -1;
                TBStudentNo.ResetText();
            }
         
        }
        long bookId = 0;
        private void CBBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookId = long.Parse(CBBookName.Text.Split(';')[0].Trim());
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB ; database = Library; integrated security = True";
            SqlCommand cmd;
            con.Open();
            cmd = new SqlCommand("Select BookPrice from BookTbl where BookID = '"+ bookId + "'",con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            if(TBStudentNo.Text !="")
              TBPrice.Text = (long.Parse( dataSet.Tables[0].Rows[0][0].ToString())/2).ToString();
            else
                TBPrice.Text = dataSet.Tables[0].Rows[0][0].ToString();
            TBPrice.Text += " ₺";
        }
      

        private void EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSave_Click("obj", EventArgs.Empty);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Maarif Kütüphaneleri",new Font("Century Gothic",12, FontStyle.Bold),Brushes.Black, new Point(140));
            e.Graphics.DrawString("Kitap İsmi                Fiyat               Teslim Tarihi", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(45,40));
            e.Graphics.DrawString("" + CBBookName.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(5, 70));
            e.Graphics.DrawString("" + TBPrice.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(195, 70));
            e.Graphics.DrawString("" + DTPBorrowDate.Value.Day.ToString() +"/"+ (DTPBorrowDate.Value.Month+1).ToString()+"/"+ DTPBorrowDate.Value.Year.ToString(), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(330, 70));
            e.Graphics.DrawString("****************" + TBEmail.Text+ "*****************", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(20, 150));
            e.Graphics.DrawString("**********************"+TBTC.Text+"**********************", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(20, 180));


        }
    }
}

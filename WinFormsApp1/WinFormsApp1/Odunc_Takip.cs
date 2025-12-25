using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Drawing; 

namespace WinFormsApp1
{
    public partial class Odunc_Takip : Form
    {
        private readonly string _userName;
        private readonly string _userEmail;
        private int _userId;

        public Odunc_Takip(string userName, string email)
        {
            InitializeComponent();
            _userName = userName;
            _userEmail = email;

            
            Color userMenuColor = Color.DarkGoldenrod;
            Color activeColor = Color.Goldenrod;
            Color exitColor = Color.Firebrick;
            Color foregroundColor = Color.White;

           
            ana_button.BackColor = userMenuColor;
            ana_button.ForeColor = foregroundColor;

            kitap_list_button.BackColor = userMenuColor;
            kitap_list_button.ForeColor = foregroundColor;

            kitap_aara_button.BackColor = userMenuColor;
            kitap_aara_button.ForeColor = foregroundColor;

            odunc_talep_button.BackColor = userMenuColor;
            odunc_talep_button.ForeColor = foregroundColor;

            odunc_takip_button.BackColor = activeColor; 
            odunc_takip_button.ForeColor = foregroundColor;

            exit_button.BackColor = exitColor;
            exit_button.ForeColor = foregroundColor;

            
            StyleDataGridView(dataGridViewTakip, userMenuColor, Color.OldLace);



            LoadUserId();
            ListeleGecmisTalepler();

        }

        private void StyleDataGridView(DataGridView dgv, Color headerColor, Color altRowColor)
        {
            dgv.EnableHeadersVisualStyles = false;

          
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font.FontFamily, 10, FontStyle.Bold);

            
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = altRowColor;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Peru; 
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.BackgroundColor = Color.WhiteSmoke;
        }

        private void LoadUserId()
        {
            using SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;");
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT KullaniciID FROM Kullanicilar WHERE Email=@mail", conn);
            cmd.Parameters.AddWithValue("@mail", _userEmail);

            object result = cmd.ExecuteScalar();
            _userId = result == null ? 0 : Convert.ToInt32(result);
        }

        private void ListeleGecmisTalepler()
        {
            using SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;");
            conn.Open();

            string sql = @"
                SELECT 
                    o.IslemID AS 'İşlem No',
                    k.KitapAdi AS 'Kitap Adı',
                    k.Yazar,
                    k.RafNo AS 'Raf',
                    o.TalepTarihi AS 'Talep Tarihi',
                    o.OnayTarihi AS 'Onay Tarihi',
                    o.TeslimTarihi AS 'Teslim Tarihi',
                    d.DurumAdi AS 'Durum'
                FROM OduncIslemleri o
                INNER JOIN Kitaplar k ON o.KitapID = k.KitapID
                INNER JOIN OduncDurumlari d ON o.DurumID = d.DurumID
                WHERE o.KullaniciID = @kul
                AND o.DurumID = 4
                ORDER BY o.TalepTarihi DESC";

            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kul", _userId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewTakip.DataSource = dt;
        }

       

        private void ana_button_Click_1(object sender, EventArgs e)
        {
            UserPage u = new UserPage(_userName, _userEmail);
            u.Show();
            this.Hide();
        }

        private void kitap_list_button_Click_1(object sender, EventArgs e)
        {
            Kitap_List k = new Kitap_List(_userName, _userEmail);
            k.Show();
            this.Hide();
        }

        private void kitap_aara_button_Click_1(object sender, EventArgs e)
        {
            Kitap_ara k = new Kitap_ara(_userName, _userEmail);
            k.Show();
            this.Hide();
        }

        private void odunc_talep_button_Click_1(object sender, EventArgs e)
        {
            Odunc_Talep o = new Odunc_Talep(_userName, _userEmail);
            o.Show();
            this.Hide();
        }

        private void odunc_takip_button_Click_1(object sender, EventArgs e)
        {
            
        }

        private void exit_button_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

    }
}
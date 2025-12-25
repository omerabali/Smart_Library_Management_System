using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Drawing; 

namespace WinFormsApp1
{
    public partial class Odunc_Talep : Form
    {
        private readonly string _userName;
        private readonly string _userEmail;
        private int _userId;

        
        public Odunc_Talep(string userName, string email)
        {
            InitializeComponent();
            _userName = userName;
            _userEmail = email;

            
            ApplyStyle();

            InitForm();
        }

        
        public Odunc_Talep(string email, int kitapID)
        {
            InitializeComponent();
            _userEmail = email;

            
            ApplyStyle();

            InitForm();

            if (kitapID > 0)
            {
                KaydetYeniTalep(kitapID);

                MessageBox.Show(
                    "Talebiniz başarıyla alınmıştır!",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ListeleAktifTalepler();
            }
        }

        
        private void ApplyStyle()
        {
            
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

            odunc_talep_button.BackColor = activeColor; 
            odunc_talep_button.ForeColor = foregroundColor;

            odunc_takip_button.BackColor = userMenuColor;
            odunc_takip_button.ForeColor = foregroundColor;

            exit_button.BackColor = exitColor;
            exit_button.ForeColor = foregroundColor;

            
            StyleDataGridView(dataGridViewTalep, userMenuColor, Color.OldLace);

            
            ana_button.Click += ana_button_Click_1;
            kitap_list_button.Click += kitap_list_button_Click_1;
            kitap_aara_button.Click += kitap_aara_button_Click_1;
            odunc_talep_button.Click += odunc_talep_button_Click_1;
            odunc_takip_button.Click += odunc_takip_button_Click_1;
            exit_button.Click += exit_button_Click_1;
        }

        
        private void StyleDataGridView(DataGridView dgv, Color headerColor, Color altRowColor)
        {
            dgv.EnableHeadersVisualStyles = false;

            // Başlık Stili
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font.FontFamily, 10, FontStyle.Bold);

            // Satır Stili
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = altRowColor;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Peru;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.BackgroundColor = Color.WhiteSmoke;
        }


        private void InitForm()
        {
            LoadUserId();
            ListeleAktifTalepler();
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

        private void KaydetYeniTalep(int kitapID)
        {
            using SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;");
            conn.Open();

            string sql = @"
                INSERT INTO OduncIslemleri 
                    (KullaniciID, KitapID, DurumID, TalepTarihi, SonIadeTarihi)
                VALUES 
                    (@kul, @kit, 1, GETDATE(), DATEADD(DAY, 14, GETDATE()))";

            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kul", _userId);
            cmd.Parameters.AddWithValue("@kit", kitapID);
            cmd.ExecuteNonQuery();
        }

        private void ListeleAktifTalepler()
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
                    o.SonIadeTarihi AS 'Son İade Tarihi',
                    d.DurumAdi AS 'Durum'
                FROM OduncIslemleri o
                INNER JOIN Kitaplar k ON o.KitapID = k.KitapID
                INNER JOIN OduncDurumlari d ON o.DurumID = d.DurumID
                WHERE o.KullaniciID = @kul
                AND o.DurumID IN (1,2,3,5)
                ORDER BY o.TalepTarihi DESC";

            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kul", _userId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewTalep.DataSource = dt;
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
          
        }

        private void odunc_takip_button_Click_1(object sender, EventArgs e)
        {
            Odunc_Takip o = new Odunc_Takip(_userName, _userEmail);
            o.Show();
            this.Hide();
        }

        private void exit_button_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Drawing; // Renkleri kullanmak için eklendi

namespace WinFormsApp1
{
    public partial class Personel_GunlukIslemler : Form
    {
        private readonly string _ad;
        private readonly string _mail;

        public Personel_GunlukIslemler(string ad, string mail)
        {
            InitializeComponent();
            _ad = ad;
            _mail = mail;

          

            Color personelMenuColor = Color.FromArgb(0, 71, 160); 
            Color activeColor = Color.FromArgb(0, 100, 200); 
            Color exitColor = Color.Firebrick; 
            Color foregroundColor = Color.White; 

            // --- Menü Butonları Stili ---
            ana_button.BackColor = personelMenuColor;
            ana_button.ForeColor = foregroundColor;

            odunc_button.BackColor = personelMenuColor;
            odunc_button.ForeColor = foregroundColor;

            durum_button.BackColor = personelMenuColor;
            durum_button.ForeColor = foregroundColor;

            gunluk_button.BackColor = activeColor; // Aktif sayfa vurgusu
            gunluk_button.ForeColor = foregroundColor;

            exit_button.BackColor = exitColor;
            exit_button.ForeColor = foregroundColor;

            /
            GridAyarla(dgvVerilen);
            GridAyarla(dgvIade);
            GridAyarla(dgvGeciken);

            // Gecikenler için özel renk vurgusu ekliyoruz
            dgvGeciken.CellFormatting += DgvGeciken_CellFormatting;

           

            Yukle_Verilen();
            Yukle_Iade();
            Yukle_Geciken();

            // --- Menü Event Atamaları ---
            ana_button.Click += ana_button_Click;
            odunc_button.Click += odunc_button_Click;
            durum_button.Click += durum_button_Click;
            gunluk_button.Click += gunluk_button_Click;
            exit_button.Click += exit_button_Click;
        }

        
        private void GridAyarla(DataGridView dgv)
        {
            
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;

            // --- Tutarlı Görsel Stil ---
            Color personelMenuColor = Color.FromArgb(0, 71, 160); // Koyu Lacivert/Mavi
            Color altRowColor = Color.FromArgb(240, 240, 255); // Açık Mavi/Gri

            dgv.EnableHeadersVisualStyles = false;

            
            dgv.ColumnHeadersDefaultCellStyle.BackColor = personelMenuColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font.FontFamily, 10, FontStyle.Bold);

            // Satır Stili
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = altRowColor;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue; // Seçim rengi
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            
        }

        //
        private void DgvGeciken_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvGeciken.Columns["Gecikme"] != null &&
                e.ColumnIndex == dgvGeciken.Columns["Gecikme"].Index)
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int gecikmeGun))
                {
                    Color altRowColor = Color.FromArgb(240, 240, 255);

                    if (gecikmeGun > 0)
                    {
                        // Gecikme varsa tüm satırı kırmızı yap
                        dgvGeciken.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        dgvGeciken.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        // Alternatif satır rengini geri yükle
                        dgvGeciken.Rows[e.RowIndex].DefaultCellStyle.BackColor = e.RowIndex % 2 == 0 ? Color.White : altRowColor;
                        dgvGeciken.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        private SqlConnection Baglanti()
        {
            return new SqlConnection(
                "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;");
        }

     
        private void Yukle_Verilen()
        {
            dgvVerilen.Rows.Clear();
            dgvVerilen.Columns.Clear();

            dgvVerilen.Columns.Add("Kitap", "Kitap");
            dgvVerilen.Columns.Add("Ogrenci", "Öğrenci");
            dgvVerilen.Columns.Add("TalepTarihi", "Talep Tarihi");

            using SqlConnection conn = Baglanti();
            conn.Open();

            string sql = @"
                SELECT K.KitapAdi, CONCAT(U.Ad,' ',U.Soyad) AS Ogrenci, O.TalepTarihi
                FROM OduncIslemleri O
                INNER JOIN Kitaplar K ON O.KitapID = K.KitapID
                INNER JOIN Kullanicilar U ON O.KullaniciID = U.KullaniciID
                WHERE CAST(O.TalepTarihi AS DATE) = CAST(GETDATE() AS DATE)
                AND O.DurumID = 2; -- Onaylandı
            ";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (!dr.HasRows)
            {
                dgvVerilen.Rows.Add("Bugün hiç kitap verilmedi.", "", "");
                dgvVerilen.Rows[0].DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                return;
            }

            while (dr.Read())
            {
                dgvVerilen.Rows.Add(
                    dr["KitapAdi"],
                    dr["Ogrenci"],
                    Convert.ToDateTime(dr["TalepTarihi"]).ToString("dd.MM.yyyy HH:mm")
                );
            }
        }

       
        private void Yukle_Iade()
        {
            dgvIade.Rows.Clear();
            dgvIade.Columns.Clear();

            dgvIade.Columns.Add("Kitap", "Kitap");
            dgvIade.Columns.Add("Ogrenci", "Öğrenci");
            dgvIade.Columns.Add("IadeTarihi", "İade Tarihi");

            using SqlConnection conn = Baglanti();
            conn.Open();

            string sql = @"
                SELECT K.KitapAdi, CONCAT(U.Ad,' ',U.Soyad) AS Ogrenci, O.IadeTarihi
                FROM OduncIslemleri O
                INNER JOIN Kitaplar K ON O.KitapID = K.KitapID
                INNER JOIN Kullanicilar U ON O.KullaniciID = U.KullaniciID
                WHERE CAST(O.IadeTarihi AS DATE) = CAST(GETDATE() AS DATE)
            ";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (!dr.HasRows)
            {
                dgvIade.Rows.Add("Bugün hiç iade yapılmadı.", "", "");
                dgvIade.Rows[0].DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                return;
            }

            while (dr.Read())
            {
                dgvIade.Rows.Add(
                    dr["KitapAdi"],
                    dr["Ogrenci"],
                    Convert.ToDateTime(dr["IadeTarihi"]).ToString("dd.MM.yyyy")
                );
            }
        }

        private void Yukle_Geciken()
        {
            dgvGeciken.Rows.Clear();
            dgvGeciken.Columns.Clear();

            dgvGeciken.Columns.Add("Kitap", "Kitap");
            dgvGeciken.Columns.Add("Ogrenci", "Öğrenci");
            dgvGeciken.Columns.Add("Teslim", "Teslim Tarihi");
            dgvGeciken.Columns.Add("Gecikme", "Gecikme (Gün)");

            using SqlConnection conn = Baglanti();
            conn.Open();

            string sql = @"
                SELECT 
                    K.KitapAdi,
                    CONCAT(U.Ad,' ',U.Soyad) AS Ogrenci,
                    O.TeslimTarihi,
                    DATEDIFF(DAY, O.TeslimTarihi, GETDATE()) AS GecikmeGun
                FROM OduncIslemleri O
                INNER JOIN Kitaplar K ON O.KitapID = K.KitapID
                INNER JOIN Kullanicilar U ON O.KullaniciID = U.KullaniciID
                WHERE O.IadeTarihi IS NULL  
                AND O.TeslimTarihi < GETDATE()
            ";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (!dr.HasRows)
            {
                dgvGeciken.Rows.Add("Geciken kitap yok.", "", "", "");
                dgvGeciken.Rows[0].DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                return;
            }

            while (dr.Read())
            {
                dgvGeciken.Rows.Add(
                    dr["KitapAdi"],
                    dr["Ogrenci"],
                    Convert.ToDateTime(dr["TeslimTarihi"]).ToString("dd.MM.yyyy"),
                    dr["GecikmeGun"]
                );
            }
        }

      
        private void ana_button_Click(object sender, EventArgs e)
        {
            PersonelPage p = new PersonelPage(_ad, _mail);
            p.Show();
            this.Hide();
        }

        private void odunc_button_Click(object sender, EventArgs e)
        {
            Personel_OduncListe p = new Personel_OduncListe(_ad, _mail);
            p.Show();
            this.Hide();
        }

        private void durum_button_Click(object sender, EventArgs e)
        {
            Personel_DurumDegisimi p = new Personel_DurumDegisimi(_ad, _mail);
            p.Show();
            this.Hide();
        }

        private void gunluk_button_Click(object sender, EventArgs e)
        {
            // Bu sayfadasın
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
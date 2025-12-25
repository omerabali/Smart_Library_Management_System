using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing; 

namespace WinFormsApp1
{
    public partial class Admin_Rapor : Form
    {
        private readonly string? _adminName;
        private readonly string? _adminEmail;

        private readonly string connStr =
            "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;";

        
        public Admin_Rapor()
        {
            InitializeComponent();
        }

       
        public Admin_Rapor(string adminName, string adminEmail)
        {
            InitializeComponent();
            _adminName = adminName;
            _adminEmail = adminEmail;

           

            // --- Menü Butonları Stili (Önceki Sayfadan Korundu) ---
            Color menuColor = Color.FromArgb(100, 43, 137); // Koyu Mor (Ana Menü)
            Color exitColor = Color.Firebrick; // Kırmızı (Çıkış)
            Color foregroundColor = Color.White; // Beyaz yazı

            ana_button.BackColor = menuColor;
            ana_button.ForeColor = foregroundColor;
            kitap_button.BackColor = menuColor;
            kitap_button.ForeColor = foregroundColor;
            user_man_button.BackColor = menuColor;
            user_man_button.ForeColor = foregroundColor;
            rapor_button.BackColor = menuColor;
            rapor_button.ForeColor = foregroundColor;

          

            exit_button.BackColor = exitColor;
            exit_button.ForeColor = foregroundColor;

            
            filtre_button.BackColor = Color.SteelBlue; // Çelik Mavisi
            filtre_button.ForeColor = Color.White;

            // --- DataGridView Stilleri (Raporlama için) ---
            Color headerColor = menuColor; // Başlık rengini menü rengiyle uyumlu tutalım
            Color altRowColor = Color.FromArgb(240, 240, 255); // Açık Mavi/Gri (Alternatif satır için)

            
            dvgUst.EnableHeadersVisualStyles = false;
            dvgUst.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dvgUst.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgUst.ColumnHeadersDefaultCellStyle.Font = new Font(dvgUst.Font, FontStyle.Bold);
            dvgUst.RowsDefaultCellStyle.BackColor = Color.White;
            dvgUst.AlternatingRowsDefaultCellStyle.BackColor = altRowColor;

            // dvgAlt (Alt Grid) Stilleri
            dvgAlt.EnableHeadersVisualStyles = false;
            dvgAlt.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dvgAlt.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgAlt.ColumnHeadersDefaultCellStyle.Font = new Font(dvgAlt.Font, FontStyle.Bold);
            dvgAlt.RowsDefaultCellStyle.BackColor = Color.White;
            dvgAlt.AlternatingRowsDefaultCellStyle.BackColor = altRowColor;
        }

        
        private void filtre_button_Click(object sender, EventArgs e)
        {
            dvgUst.DataSource = null;
            dvgAlt.DataSource = null;

            if (dtBas.Value.Date > dtBit.Value.Date)
            {
                MessageBox.Show("Başlangıç tarihi bitişten büyük olamaz!");
                return;
            }

           
            if (!rbGunluk.Checked && !rbHaftalık.Checked && !rbAylık.Checked)
            {
                Yukle_Tarih_Araligi();
            }
            else
            {
                Yukle_Periyot_Ozet();
            }

            // CheckBox'lara göre grid görünürlüğü
            dvgUst.Visible = checkBox1.Checked;
            dvgAlt.Visible = checkBox2.Checked;
        }

        
        private void Yukle_Periyot_Ozet()
        {
            if (rbGunluk.Checked)
                Yukle_Gunluk();
            else if (rbHaftalık.Checked)
                Yukle_Haftalik();
            else if (rbAylık.Checked)
                Yukle_Aylik();
        }

     
        private void Yukle_Gunluk()
        {
            string sql = @"
                SELECT 
                    CAST(TalepTarihi AS DATE) AS Gun,
                    COUNT(*) AS Toplam
                FROM OduncIslemleri
                WHERE TalepTarihi >= DATEADD(DAY, -30, CAST(GETDATE() AS DATE))
                GROUP BY CAST(TalepTarihi AS DATE)
                ORDER BY Gun ASC";

            dvgUst.DataSource = GetTable(sql);

            string sql2 = @"
                SELECT TOP 20 
                    K.KitapAdi,
                    COUNT(*) AS AlimSayisi
                FROM OduncIslemleri O
                JOIN Kitaplar K ON O.KitapID = K.KitapID
                WHERE TalepTarihi >= DATEADD(DAY, -30, CAST(GETDATE() AS DATE))
                GROUP BY K.KitapAdi
                ORDER BY AlimSayisi DESC";

            dvgAlt.DataSource = GetTable(sql2);
        }

       
        private void Yukle_Haftalik()
        {
            string sql = @"
                SELECT 
                    DATEPART(YEAR, TalepTarihi) AS Yil,
                    DATEPART(WEEK, TalepTarihi) AS Hafta,
                    COUNT(*) AS Toplam
                FROM OduncIslemleri
                WHERE TalepTarihi >= DATEADD(WEEK, -12, GETDATE())
                GROUP BY DATEPART(YEAR, TalepTarihi), DATEPART(WEEK, TalepTarihi)
                ORDER BY Yil, Hafta";

            dvgUst.DataSource = GetTable(sql);

            string sql2 = @"
                SELECT TOP 20
                    K.KitapAdi,
                    COUNT(*) AS AlimSayisi
                FROM OduncIslemleri O
                JOIN Kitaplar K ON O.KitapID = K.KitapID
                WHERE TalepTarihi >= DATEADD(WEEK, -12, GETDATE())
                GROUP BY K.KitapAdi
                ORDER BY AlimSayisi DESC";

            dvgAlt.DataSource = GetTable(sql2);
        }

     
        private void Yukle_Aylik()
        {
            string sql = @"
                SELECT
                    DATEPART(YEAR, TalepTarihi) AS Yil,
                    DATEPART(MONTH, TalepTarihi) AS Ay,
                    COUNT(*) AS Toplam
                FROM OduncIslemleri
                WHERE TalepTarihi >= DATEADD(MONTH, -12, GETDATE())
                GROUP BY DATEPART(YEAR, TalepTarihi), DATEPART(MONTH, TalepTarihi)
                ORDER BY Yil, Ay";

            dvgUst.DataSource = GetTable(sql);

            string sql2 = @"
                SELECT TOP 20
                    K.KitapAdi,
                    COUNT(*) AS AlimSayisi
                FROM OduncIslemleri O
                JOIN Kitaplar K ON O.KitapID = K.KitapID
                WHERE TalepTarihi >= DATEADD(MONTH, -12, GETDATE())
                GROUP BY K.KitapAdi
                ORDER BY AlimSayisi DESC";

            dvgAlt.DataSource = GetTable(sql2);
        }

       
        private void Yukle_Tarih_Araligi()
        {
            DateTime bas = dtBas.Value.Date;
            DateTime bit = dtBit.Value.Date.AddDays(1);

            string sql = @"
                SELECT 
                    CAST(TalepTarihi AS DATE) AS Gun,
                    COUNT(*) AS Toplam
                FROM OduncIslemleri
                WHERE TalepTarihi >= @bas AND TalepTarihi < @bit
                GROUP BY CAST(TalepTarihi AS DATE)
                ORDER BY Gun ASC";

            dvgUst.DataSource = GetTable(sql, bas, bit);

            if (checkBox2.Checked)
            {
                string sql2 = @"
                    SELECT TOP 20 
                        K.KitapAdi,
                        COUNT(*) AS AlimSayisi
                    FROM OduncIslemleri O
                    JOIN Kitaplar K ON O.KitapID = K.KitapID
                    WHERE TalepTarihi >= @bas AND TalepTarihi < @bit
                    GROUP BY K.KitapAdi
                    ORDER BY AlimSayisi DESC";

                dvgAlt.DataSource = GetTable(sql2, bas, bit);
            }
        }

       
        private DataTable GetTable(string sql, DateTime? bas = null, DateTime? bit = null)
        {
            using SqlConnection conn = new SqlConnection(connStr);
            using SqlCommand cmd = new SqlCommand(sql, conn);

            if (bas != null && bit != null)
            {
                cmd.Parameters.AddWithValue("@bas", bas);
                cmd.Parameters.AddWithValue("@bit", bit);
            }

            using SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        
        private void ana_button_Click(object sender, EventArgs e)
        {
             
             AdminPage ap = new AdminPage("Admin", "admin@mail.com");
             ap.Show();
             this.Hide();
        }

        private void kitap_button_Click(object sender, EventArgs e)
        {
            
             Admin_Kitap ak = new Admin_Kitap("Admin", "admin@mail.com");
             ak.Show();
             this.Hide();
        }

        private void user_man_button_Click(object sender, EventArgs e)
        {
             Admin_UserManagement um = new Admin_UserManagement("Admin", "admin@mail.com");
             um.Show();
             this.Hide();
        }

        private void rapor_button_Click(object sender, EventArgs e)
        {
           
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
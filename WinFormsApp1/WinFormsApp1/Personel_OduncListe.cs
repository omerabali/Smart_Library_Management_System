using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Drawing; // Renkleri kullanmak için eklendi
using System.Data; 

namespace WinFormsApp1
{
    public partial class Personel_OduncListe : Form
    {
        private readonly string _ad;
        private readonly string _mail;

        public Personel_OduncListe(string ad, string mail)
        {
            InitializeComponent();

            _ad = ad;
            _mail = mail;

          

           
            Color personelMenuColor = Color.FromArgb(0, 71, 160);
            Color activeColor = Color.FromArgb(0, 100, 200); 
            Color exitColor = Color.Firebrick; 
            Color foregroundColor = Color.White; 
            Color buttonInceleColor = Color.SteelBlue; 

            ana_button.BackColor = personelMenuColor;
            ana_button.ForeColor = foregroundColor;

            odunc_button.BackColor = activeColor; // Aktif sayfa vurgusu
            odunc_button.ForeColor = foregroundColor;

            durum_button.BackColor = personelMenuColor;
            durum_button.ForeColor = foregroundColor;

            gunluk_button.BackColor = personelMenuColor;
            gunluk_button.ForeColor = foregroundColor;

            exit_button.BackColor = exitColor;
            exit_button.ForeColor = foregroundColor;

            

            HazirlaGrid();
            ListeYukle();

            // --- DataGridView Stili Uygulama ---
            StyleDataGridView(dataGridView1, personelMenuColor, Color.FromArgb(240, 240, 255), buttonInceleColor);

            dataGridView1.CellClick += dataGridView1_CellClick;

            // --- Menü Event Atamaları ---
            ana_button.Click += ana_button_Click;
            odunc_button.Click += odunc_button_Click; 
            durum_button.Click += durum_button_Click;
            gunluk_button.Click += gunluk_button_Click;
            exit_button.Click += exit_button_Click;
        }

       
        private void StyleDataGridView(DataGridView dgv, Color headerColor, Color altRowColor, Color btnColor)
        {
            dgv.EnableHeadersVisualStyles = false;

            // Başlık Stili
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);

            // Satır Stili
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = altRowColor;

            // Buton Stili (Eğer varsa)
            if (dgv.Columns.Contains("Incele"))
            {
                dgv.Columns["Incele"].DefaultCellStyle.BackColor = btnColor;
                dgv.Columns["Incele"].DefaultCellStyle.ForeColor = Color.White;
            }
        }



        private void HazirlaGrid()
        {
            var dgv = dataGridView1;

            dgv.Columns.Clear();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowTemplate.Height = 30;

            // Gizli kitap ID kolonu
            dgv.Columns.Add("KitapID", "Kitap ID");
            dgv.Columns["KitapID"].Visible = false;

            dgv.Columns.Add("Kitap", "Kitap");
            dgv.Columns.Add("TalepEden", "Talep Eden");
            dgv.Columns.Add("TalepTarih", "Talep Tarihi");
            dgv.Columns.Add("Durum", "Durum");

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn
            {
                Name = "Incele",
                HeaderText = "İşlem",
                Text = "İncele",
                UseColumnTextForButtonValue = true
            };

            dgv.Columns.Add(btn);
        }

        
        private void ListeYukle()
        {
            dataGridView1.Rows.Clear();

            using SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;");
            conn.Open();

            string sql = @"
                SELECT 
                    O.KitapID,
                    K.KitapAdi AS Kitap,
                    CONCAT(U.Ad, ' ', U.Soyad) AS TalepEden,
                    O.TalepTarihi,
                    D.DurumAdi AS Durum,
                    O.KullaniciID,
                    O.DurumID
                FROM OduncIslemleri O
                INNER JOIN Kitaplar K ON O.KitapID = K.KitapID
                INNER JOIN Kullanicilar U ON O.KullaniciID = U.KullaniciID
                INNER JOIN OduncDurumlari D ON O.DurumID = D.DurumID
                WHERE D.DurumAdi = 'Beklemede';
            ";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(
                    dr["KitapID"],
                    dr["Kitap"],
                    dr["TalepEden"],
                    Convert.ToDateTime(dr["TalepTarihi"]).ToString("dd.MM.yyyy HH:mm"),
                    dr["Durum"]
                );
            }
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name != "Incele")
                return;

            int kitapID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["KitapID"].Value);
            string kitapAd = dataGridView1.Rows[e.RowIndex].Cells["Kitap"].Value.ToString();
            string talepEden = dataGridView1.Rows[e.RowIndex].Cells["TalepEden"].Value.ToString();
            string tarih = dataGridView1.Rows[e.RowIndex].Cells["TalepTarih"].Value.ToString();
            string durum = dataGridView1.Rows[e.RowIndex].Cells["Durum"].Value.ToString();

            string yazar = "-", isbn = "-", yil = "-", stok = "-", raf = "-", ozet = "-";

            try
            {
                using SqlConnection conn = new SqlConnection(
                    "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;");
                conn.Open();

                string sql = @"
                    SELECT Yazar, ISBN, YayinYili, StokAdedi, RafNo, Ozet
                    FROM Kitaplar
                    WHERE KitapID = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", kitapID);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    yazar = dr["Yazar"]?.ToString() ?? "-";
                    isbn = dr["ISBN"]?.ToString() ?? "-";
                    yil = dr["YayinYili"]?.ToString() ?? "-";
                    stok = dr["StokAdedi"]?.ToString() ?? "-";
                    raf = dr["RafNo"]?.ToString() ?? "-";
                    ozet = dr["Ozet"]?.ToString() ?? "-";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap bilgisi getirilemedi:\n" + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string detayMetin =
                "===== KİTAP BİLGİSİ =====\n" +
                $"Kitap Adı: {kitapAd}\n" +
                $"Yazar: {yazar}\n" +
                $"ISBN: {isbn}\n" +
                $"Yayın Yılı: {yil}\n" +
                $"Stok Adedi: {stok}\n" +
                $"Raf No: {raf}\n\n" +
                $"Özet:\n{ozet}\n\n" +
                "===== TALEP BİLGİSİ =====\n" +
                $"Talep Eden: {talepEden}\n" +
                $"Talep Tarihi: {tarih}\n" +
                $"Durum: {durum}\n";

            MessageBox.Show(detayMetin, "Ödünç Talep Detayı",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        private void ana_button_Click(object sender, EventArgs e)
        {
            PersonelPage p = new PersonelPage(_ad, _mail);
            p.Show();
            this.Hide();
        }

        private void odunc_button_Click(object sender, EventArgs e)
        {
           
        }

        private void durum_button_Click(object sender, EventArgs e)
        {
            Personel_DurumDegisimi p = new Personel_DurumDegisimi(_ad, _mail);
            p.Show();
            this.Hide();
        }

        private void gunluk_button_Click(object sender, EventArgs e)
        {
            Personel_GunlukIslemler p = new Personel_GunlukIslemler(_ad, _mail);
            p.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
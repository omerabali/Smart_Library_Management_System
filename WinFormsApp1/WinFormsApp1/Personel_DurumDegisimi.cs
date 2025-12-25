using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Data;

namespace WinFormsApp1
{
    public partial class Personel_DurumDegisimi : Form
    {
        private readonly string _ad;
        private readonly string _mail;

        private readonly string ConnectionString =
            "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;";

        private readonly BindingSource durumListesi = new BindingSource();

     
        public Personel_DurumDegisimi(string ad, string mail)
        {
            InitializeComponent();

            _ad = ad;
            _mail = mail;

            ApplyStyle();
            HazirlaGrid();
            DurumlariYukle();
            ListeYukle();

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

      
        private void ApplyStyle()
        {
            Color menuColor = Color.FromArgb(0, 71, 160);
            Color activeColor = Color.FromArgb(0, 100, 200);
            Color exitColor = Color.Firebrick;
            Color textColor = Color.White;

            ana_button.BackColor = menuColor;
            odunc_button.BackColor = menuColor;
            durum_button.BackColor = activeColor;
            gunluk_button.BackColor = menuColor;
            exit_button.BackColor = exitColor;

            ana_button.ForeColor =
            odunc_button.ForeColor =
            durum_button.ForeColor =
            gunluk_button.ForeColor =
            exit_button.ForeColor = textColor;

            StyleDataGridView(dataGridView1, menuColor, Color.FromArgb(240, 240, 255));
        }

        private static void StyleDataGridView(DataGridView dgv, Color headerColor, Color altRowColor)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = altRowColor;
        }

       
        private void HazirlaGrid()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("IslemID", "IslemID");
            dataGridView1.Columns["IslemID"].Visible = false;

            dataGridView1.Columns.Add("Kitap", "Kitap");
            dataGridView1.Columns.Add("TalepEden", "Talep Eden");
            dataGridView1.Columns.Add("TalepTarihi", "Talep Tarihi");
            dataGridView1.Columns.Add("Durum", "Durum");

            DataGridViewComboBoxColumn combo = new()
            {
                Name = "YeniDurum",
                HeaderText = "Yeni Durum",
                DisplayMember = "Ad",
                ValueMember = "ID"
            };
            dataGridView1.Columns.Add(combo);

            DataGridViewButtonColumn btn = new()
            {
                Name = "Guncelle",
                HeaderText = "Güncelle",
                Text = "Kaydet",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(btn);
        }

        private void DurumlariYukle()
        {
            durumListesi.Clear();

            using SqlConnection conn = new(ConnectionString);
            conn.Open();

            string sql = "SELECT DurumID, DurumAdi FROM OduncDurumlari";
            using SqlCommand cmd = new(sql, conn);
            using SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                durumListesi.Add(new DurumModel
                {
                    ID = (int)dr["DurumID"],
                    Ad = dr["DurumAdi"]!.ToString()!
                });
            }

            ((DataGridViewComboBoxColumn)dataGridView1.Columns["YeniDurum"]).DataSource = durumListesi;
        }

       
        private void ListeYukle()
        {
            dataGridView1.Rows.Clear();

            using SqlConnection conn = new(ConnectionString);
            conn.Open();

            string sql = @"
                SELECT O.IslemID, K.KitapAdi,
                       CONCAT(U.Ad, ' ', U.Soyad) AS TalepEden,
                       O.TalepTarihi, D.DurumAdi, O.DurumID
                FROM OduncIslemleri O
                INNER JOIN Kitaplar K ON O.KitapID = K.KitapID
                INNER JOIN Kullanicilar U ON O.KullaniciID = U.KullaniciID
                INNER JOIN OduncDurumlari D ON O.DurumID = D.DurumID
                ORDER BY O.TalepTarihi DESC";

            using SqlCommand cmd = new(sql, conn);
            using SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int row = dataGridView1.Rows.Add(
                    dr["IslemID"],
                    dr["KitapAdi"],
                    dr["TalepEden"],
                    Convert.ToDateTime(dr["TalepTarihi"]).ToString("dd.MM.yyyy HH:mm"),
                    dr["DurumAdi"],
                    null,
                    "Kaydet"
                );

                dataGridView1.Rows[row].Cells["YeniDurum"].Value = (int)dr["DurumID"];
            }
        }

        
        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex].Name != "Guncelle")
                return;

            int islemID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IslemID"].Value);
            int yeniDurumID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["YeniDurum"].Value);

            using SqlConnection conn = new(ConnectionString);
            conn.Open();

            int eskiDurumID = 0;
            int kitapID = 0;

            using (SqlCommand cmd = new("SELECT DurumID, KitapID FROM OduncIslemleri WHERE IslemID=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", islemID);
                using SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    eskiDurumID = (int)dr["DurumID"];
                    kitapID = (int)dr["KitapID"];
                }
            }

            int stokDegisim = 0;
            if (yeniDurumID == 2 && eskiDurumID != 2) stokDegisim = -1;
            if (yeniDurumID == 3 && eskiDurumID != 3) stokDegisim = 1;

            using (SqlCommand cmd = new(
                "UPDATE OduncIslemleri SET DurumID=@d, IadeTarihi=" +
                (yeniDurumID == 3 ? "GETDATE()" : "NULL") +
                " WHERE IslemID=@id", conn))
            {
                cmd.Parameters.AddWithValue("@d", yeniDurumID);
                cmd.Parameters.AddWithValue("@id", islemID);
                cmd.ExecuteNonQuery();
            }

            if (stokDegisim != 0)
            {
                using SqlCommand cmd = new(
                    "UPDATE Kitaplar SET StokAdedi = StokAdedi + @s WHERE KitapID=@k", conn);
                cmd.Parameters.AddWithValue("@s", stokDegisim);
                cmd.Parameters.AddWithValue("@k", kitapID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Durum ve stok başarıyla güncellendi.");
            ListeYukle();
        }

       
        private void ana_button_Click(object sender, EventArgs e)
        {
            new PersonelPage(_ad, _mail).Show();
            Hide();
        }

        private void odunc_button_Click(object sender, EventArgs e)
        {
            new Personel_OduncListe(_ad, _mail).Show();
            Hide();
        }

        private void gunluk_button_Click(object sender, EventArgs e)
        {
            new Personel_GunlukIslemler(_ad, _mail).Show();
            Hide();
        }

        private void durum_button_Click(object sender, EventArgs e)
        {
            // Zaten bu sayfadasın
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Close();
        }
    }

    public class DurumModel
    {
        public int ID { get; set; }
        public string Ad { get; set; } = string.Empty;
    }
}

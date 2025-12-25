using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Admin_Kitap : Form
    {
        private readonly string _adminName;
        private readonly string _adminEmail;

        private int _seciliKitapID = 0;

        public Admin_Kitap(string adminName, string adminEmail)
        {
            InitializeComponent();

            _adminName = adminName;
            _adminEmail = adminEmail;

            

            
            Color newMenuColor = Color.FromArgb(100, 43, 137); 
            Color exitButtonColor = Color.Firebrick; 
            Color foregroundColor = Color.White; 

            
            ana_button.BackColor = newMenuColor;
            ana_button.ForeColor = foregroundColor;
            kitap_button.BackColor = newMenuColor;
            kitap_button.ForeColor = foregroundColor;
            user_man_button.BackColor = newMenuColor;
            user_man_button.ForeColor = foregroundColor;
            rapor_button.BackColor = newMenuColor;
            rapor_button.ForeColor = foregroundColor;

            
            exit_button.BackColor = exitButtonColor;
            exit_button.ForeColor = foregroundColor;

            
            ekle_button.BackColor = Color.SeaGreen; // Yeşil
            ekle_button.ForeColor = Color.White;
            guncelle_button.BackColor = Color.Orange; // Turuncu/Sarı
            guncelle_button.ForeColor = Color.Black;

            
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = newMenuColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            
            ListeleKitaplar();
            AddButtons(); // Sil + Düzenle

            dataGridView1.CellClick += dataGridView1_CellClick;

            // Menü butonları eventleri
            ana_button.Click += ana_button_Click;
            kitap_button.Click += kitap_button_Click;
            user_man_button.Click += user_man_button_Click;
            rapor_button.Click += rapor_button_Click;
            exit_button.Click += exit_button_Click;

            ekle_button.Click += ekle_button_Click;
            guncelle_button.Click += guncelle_button_Click;
        }

        
        private void ListeleKitaplar()
        {
            using SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;");
            conn.Open();

            string sql = @"
                SELECT 
                    KitapID,
                    KitapAdi,
                    Yazar,
                    ISBN,
                    YayinYili,
                    StokAdedi,
                    RafNo,
                    Ozet,
                    KategoriID
                FROM Kitaplar";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        
        private void AddButtons()
        {
            // Sil Butonu
            if (!dataGridView1.Columns.Contains("SilButton"))
            {
                DataGridViewButtonColumn silBtn = new DataGridViewButtonColumn();
                silBtn.Name = "SilButton";
                silBtn.HeaderText = "Sil";
                silBtn.Text = "Sil";
                silBtn.UseColumnTextForButtonValue = true;
                silBtn.Width = 60;
                dataGridView1.Columns.Add(silBtn);
            }

            // Düzenle Butonu
            if (!dataGridView1.Columns.Contains("DuzenleButton"))
            {
                DataGridViewButtonColumn duzenBtn = new DataGridViewButtonColumn();
                duzenBtn.Name = "DuzenleButton";
                duzenBtn.HeaderText = "Düzenle";
                duzenBtn.Text = "Düzenle";
                duzenBtn.UseColumnTextForButtonValue = true;
                duzenBtn.Width = 80;
                dataGridView1.Columns.Add(duzenBtn);
            }
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Geçersiz tıklama engeli
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string column = dataGridView1.Columns[e.ColumnIndex].Name;

            int kitapID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["KitapID"].Value);

            // --- SİL ---
            if (column == "SilButton")
            {
                SilKitap(kitapID);
                ListeleKitaplar();
                return;
            }

            // --- DÜZENLE ---
            if (column == "DuzenleButton")
            {
                _seciliKitapID = kitapID;

                txt_gun_ad.Text = dataGridView1.Rows[e.RowIndex].Cells["KitapAdi"].Value.ToString();
                txt_gun_yazar.Text = dataGridView1.Rows[e.RowIndex].Cells["Yazar"].Value.ToString();
                txt_gun_isbn.Text = dataGridView1.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                txt_gun_yil.Text = dataGridView1.Rows[e.RowIndex].Cells["YayinYili"].Value.ToString();
                txt_gun_stok.Text = dataGridView1.Rows[e.RowIndex].Cells["StokAdedi"].Value.ToString();
                txt_gun_kat.Text = dataGridView1.Rows[e.RowIndex].Cells["KategoriID"].Value.ToString();
                txt_gun_raf.Text = dataGridView1.Rows[e.RowIndex].Cells["RafNo"].Value.ToString();
                txt_gun_ozet.Text = dataGridView1.Rows[e.RowIndex].Cells["Ozet"].Value.ToString();
            }
        }


       
        private void SilKitap(int kitapID)
        {
            DialogResult result = MessageBox.Show(
                "Bu kitabı silmek istiyor musunuz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            using SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;");
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Kitaplar WHERE KitapID=@id", conn);
            cmd.Parameters.AddWithValue("@id", kitapID);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Kitap silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        private void ekle_button_Click(object sender, EventArgs e)
        {
            // ❗ Zorunlu Alan Kontrolleri
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Kitap Adı, Yazar, ISBN, Yayın Yılı ve Kategori zorunludur!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;");
            conn.Open();

            string sql = @"
                INSERT INTO Kitaplar
                (KitapAdi, Yazar, ISBN, YayinYili, StokAdedi, RafNo, Ozet, KategoriID)
                VALUES
                (@ad, @yazar, @isbn, @yil, @stok, @raf, @ozet, @kat)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd.Parameters.AddWithValue("@yazar", textBox2.Text);
            cmd.Parameters.AddWithValue("@isbn", textBox4.Text);
            cmd.Parameters.AddWithValue("@yil", textBox3.Text);
            cmd.Parameters.AddWithValue("@stok", textBox5.Text);
            cmd.Parameters.AddWithValue("@raf", textBox8.Text);
            cmd.Parameters.AddWithValue("@ozet", textBox7.Text);
            cmd.Parameters.AddWithValue("@kat", textBox6.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Kitap başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListeleKitaplar();
        }

       
        private void guncelle_button_Click(object sender, EventArgs e)
        {
            if (_seciliKitapID == 0)
            {
                MessageBox.Show("Lütfen önce düzenlemek için bir kitap seçin!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;");
            conn.Open();

            string sql = @"
                UPDATE Kitaplar SET
                    KitapAdi=@ad,
                    Yazar=@yazar,
                    ISBN=@isbn,
                    YayinYili=@yil,
                    StokAdedi=@stok,
                    RafNo=@raf,
                    Ozet=@ozet,
                    KategoriID=@kat
                WHERE KitapID=@id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@ad", txt_gun_ad.Text);
            cmd.Parameters.AddWithValue("@yazar", txt_gun_yazar.Text);
            cmd.Parameters.AddWithValue("@isbn", txt_gun_isbn.Text);
            cmd.Parameters.AddWithValue("@yil", txt_gun_yil.Text);
            cmd.Parameters.AddWithValue("@stok", txt_gun_stok.Text);
            cmd.Parameters.AddWithValue("@raf", txt_gun_raf.Text);
            cmd.Parameters.AddWithValue("@ozet", txt_gun_ozet.Text);
            cmd.Parameters.AddWithValue("@kat", txt_gun_kat.Text);
            cmd.Parameters.AddWithValue("@id", _seciliKitapID);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Kitap başarıyla güncellendi!", "Başarılı",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListeleKitaplar();
            _seciliKitapID = 0;
        }

        
        private void ana_button_Click(object sender, EventArgs e)
        {
            AdminPage p = new AdminPage(_adminName, _adminEmail);
            p.Show();
            this.Hide();
        }

        private void kitap_button_Click(object sender, EventArgs e)
        {
            Admin_Kitap k = new Admin_Kitap(_adminName, _adminEmail);
            k.Show();
            this.Hide();
        }

        private void user_man_button_Click(object sender, EventArgs e)
        {
            Admin_UserManagement u = new Admin_UserManagement(_adminName, _adminEmail);
            u.Show();
            this.Hide();
        }

        private void rapor_button_Click(object sender, EventArgs e)
        {
            Admin_Rapor r = new Admin_Rapor(_adminName, _adminEmail);
            r.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
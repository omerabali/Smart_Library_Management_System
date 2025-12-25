using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms; // Form, DataGridView, MessageBox vb. için
using System.Drawing; // Renkleri kullanmak için eklendi

namespace WinFormsApp1
{
    public partial class Admin_UserManagement : Form
    {
        private readonly string _adminName;
        private readonly string _adminEmail;

        private int _seciliKullaniciID = 0;

        private string connStr =
            "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;";

        public Admin_UserManagement(string adminName, string adminEmail)
        {
            InitializeComponent();
            _adminName = adminName;
            _adminEmail = adminEmail;

          

           
            Color menuColor = Color.FromArgb(100, 43, 137); // Koyu Mor (Ana Menü)
            Color exitColor = Color.Firebrick; // Kırmızı (Çıkış)
            Color foregroundColor = Color.White; // Beyaz yazı

            ana_button.BackColor = menuColor;
            ana_button.ForeColor = foregroundColor;
            kitap_button.BackColor = menuColor;
            kitap_button.ForeColor = foregroundColor;
            user_man_button.BackColor = menuColor;
            user_man_button.ForeColor = foregroundColor;
            // Bu sayfada olduğumuz için aktif butona farklı ton verebiliriz
            user_man_button.BackColor = Color.FromArgb(120, 63, 157);

            rapor_button.BackColor = menuColor;
            rapor_button.ForeColor = foregroundColor;
            exit_button.BackColor = exitColor;
            exit_button.ForeColor = foregroundColor;

            // --- İşlem Butonları Stili ---
            btnEkle.BackColor = Color.SeaGreen; // Ekle: Yeşil
            btnEkle.ForeColor = Color.White;
            guncelle_button.BackColor = Color.Orange; // Güncelle: Turuncu/Sarı
            guncelle_button.ForeColor = Color.Black;

            // --- DataGridView Stilleri ---
            Color headerColor = menuColor;
            Color altRowColor = Color.FromArgb(240, 240, 255); // Açık Mavi/Gri (Alternatif satır)

            // DataGridView Öğrenciler Stilleri
            StyleDataGridView(dataGridViewOgrenciler, headerColor, altRowColor);

           
            StyleDataGridView(dataGridViewPersoneller, headerColor, altRowColor);

         

            // Menü
            ana_button.Click += ana_button_Click;
            kitap_button.Click += kitap_button_Click;
            user_man_button.Click += user_man_button_Click;
            rapor_button.Click += rapor_button_Click;
            exit_button.Click += exit_button_Click;

            // İşlem butonları
            btnEkle.Click += btnEkle_Click;
            guncelle_button.Click += btnGuncelle_Click;

            // Grid eventleri
            dataGridViewOgrenciler.CellClick += dataGridViewOgrenciler_CellClick;
            dataGridViewPersoneller.CellClick += dataGridViewPersoneller_CellClick;

            // Rol ComboBox
            cmbGunRol.Items.Add(new KeyValuePair<int, string>(1, "Öğrenci"));
            cmbGunRol.Items.Add(new KeyValuePair<int, string>(2, "Personel"));
            cmbGunRol.Items.Add(new KeyValuePair<int, string>(3, "Admin"));
            cmbGunRol.DisplayMember = "Value";
            cmbGunRol.ValueMember = "Key";
            cmbGunRol.SelectedIndex = 0;

            // Tablolar
            ListeleOgrenciler();
            ListelePersoneller();

            AddActionButtons(dataGridViewOgrenciler);
            AddActionButtons(dataGridViewPersoneller);
        }

        
        private void StyleDataGridView(DataGridView dgv, Color headerColor, Color altRowColor)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = altRowColor;
        }


        private void ListeleOgrenciler()
        {
            using SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT KullaniciID, Ad, Soyad, Email, OkulNo, Telefon, RolID 
                  FROM Kullanicilar WHERE RolID = 1", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewOgrenciler.DataSource = dt;
        }

        private void ListelePersoneller()
        {
            using SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT KullaniciID, Ad, Soyad, Email, Telefon, RolID 
                  FROM Kullanicilar WHERE RolID = 2 OR RolID = 3", conn); // RolID=3 (Admin) de eklenebilir.

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPersoneller.DataSource = dt;
        }

     
        private void AddActionButtons(DataGridView dgv)
        {
            if (!dgv.Columns.Contains("SilButton"))
            {
                DataGridViewButtonColumn sil = new DataGridViewButtonColumn();
                sil.Name = "SilButton";
                sil.Text = "Sil";
                sil.HeaderText = "Sil";
                sil.UseColumnTextForButtonValue = true;
                sil.DefaultCellStyle.BackColor = Color.Firebrick; // Sil butonu rengi
                sil.DefaultCellStyle.ForeColor = Color.White;
                dgv.Columns.Add(sil);
            }

            if (!dgv.Columns.Contains("DuzenleButton"))
            {
                DataGridViewButtonColumn duzen = new DataGridViewButtonColumn();
                duzen.Name = "DuzenleButton";
                duzen.Text = "Düzenle";
                duzen.HeaderText = "Düzenle";
                duzen.UseColumnTextForButtonValue = true;
                duzen.DefaultCellStyle.BackColor = Color.Goldenrod; // Düzenle butonu rengi
                duzen.DefaultCellStyle.ForeColor = Color.Black;
                dgv.Columns.Add(duzen);
            }
        }

       
        private void dataGridViewOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string col = dataGridViewOgrenciler.Columns[e.ColumnIndex].Name;
            int id = Convert.ToInt32(dataGridViewOgrenciler.Rows[e.RowIndex].Cells["KullaniciID"].Value);

            if (col == "SilButton")
            {
                SilKullanici(id);
                ListeleOgrenciler();
                return;
            }

            if (col == "DuzenleButton")
                YukleGuncellePaneli(dataGridViewOgrenciler, e.RowIndex);
        }

        private void dataGridViewPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string col = dataGridViewPersoneller.Columns[e.ColumnIndex].Name;

            object idObj = dataGridViewPersoneller.Rows[e.RowIndex].Cells["KullaniciID"].Value;
            if (idObj == null || idObj == DBNull.Value)
                return;

            int id = Convert.ToInt32(idObj);

            if (col == "SilButton")
            {
                SilKullanici(id);
                ListeleOgrenciler();
                ListelePersoneller();
                return;
            }

            if (col == "DuzenleButton")
            {
                YukleGuncellePaneli(dataGridViewPersoneller, e.RowIndex);
            }
        }


      
        private void YukleGuncellePaneli(DataGridView dgv, int row)
        {
            _seciliKullaniciID = Convert.ToInt32(dgv.Rows[row].Cells["KullaniciID"].Value);

            txtGunAd.Text = dgv.Rows[row].Cells["Ad"].Value.ToString();
            txtGunSoyad.Text = dgv.Rows[row].Cells["Soyad"].Value.ToString();
            txtGunEmail.Text = dgv.Rows[row].Cells["Email"].Value.ToString();

          
            txtGunOkulNo.Text = dgv.Columns.Contains("OkulNo")
                ? dgv.Rows[row].Cells["OkulNo"].Value?.ToString() ?? ""
                : "";

            txtGunTelefon.Text = dgv.Rows[row].Cells["Telefon"].Value?.ToString() ?? "";

            int rolValue = Convert.ToInt32(dgv.Rows[row].Cells["RolID"].Value);

            var itemToSelect = cmbGunRol.Items.Cast<KeyValuePair<int, string>>()
                                           .FirstOrDefault(x => x.Key == rolValue);
            if (itemToSelect.Key != 0)
            {
                cmbGunRol.SelectedItem = itemToSelect;
            }

            txtGunSifre.Text = ""; 
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_seciliKullaniciID == 0)
            {
                MessageBox.Show("Düzenlemek için kullanıcı seçmelisiniz!");
                return;
            }

            int rolId = GetSelectedRole();
            if (rolId == -1) return;

            using SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sql = @"
                UPDATE Kullanicilar SET
                Ad=@ad,
                Soyad=@soyad,
                Email=@mail,
                OkulNo=@okul,
                Telefon=@tel,
                RolID=@rol";

            bool sifreVar = txtGunSifre.Text.Trim() != "";

            if (sifreVar)
                sql += ", Sifre=@sifre";

            sql += " WHERE KullaniciID=@id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@ad", txtGunAd.Text.Trim());
            cmd.Parameters.AddWithValue("@soyad", txtGunSoyad.Text.Trim());
            cmd.Parameters.AddWithValue("@mail", txtGunEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@okul", txtGunOkulNo.Text.Trim() == "" ? DBNull.Value : txtGunOkulNo.Text.Trim());
            cmd.Parameters.AddWithValue("@tel", txtGunTelefon.Text.Trim() == "" ? DBNull.Value : txtGunTelefon.Text.Trim());
            cmd.Parameters.AddWithValue("@rol", rolId);
            cmd.Parameters.AddWithValue("@id", _seciliKullaniciID);

            if (sifreVar)
            {
                if (!IsValidPassword(txtGunSifre.Text.Trim()))
                {
                    MessageBox.Show("Yeni şifre kurallara uygun değil!");
                    return;
                }

                cmd.Parameters.AddWithValue("@sifre", txtGunSifre.Text.Trim());
            }

            cmd.ExecuteNonQuery();

            MessageBox.Show("Kullanıcı güncellendi!");
            ListeleOgrenciler();
            ListelePersoneller();
        }

        // ROL ÇEKME
        private int GetSelectedRole()
        {
            if (cmbGunRol.SelectedItem is KeyValuePair<int, string> kvp)
                return kvp.Key;

            // Bu kısım, ComboBox'ta sadece KeyValuePair kullanıyorsanız gereksiz olabilir.
            if (int.TryParse(cmbGunRol.SelectedValue?.ToString(), out int v))
                return v;

            MessageBox.Show("Lütfen geçerli bir rol seçin!");
            return -1;
        }

     
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Zorunlu alan kontrol
            if (txtAd.Text.Trim() == "" ||
                txtSoyad.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "" ||
                txtSifre.Text.Trim() == "" ||
                txtRol.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurun!");
                return;
            }

            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Geçerli bir e-mail girin!");
                return;
            }

            if (txtTelefon.Text.Trim() != "" && !IsValidPhone(txtTelefon.Text.Trim()))
            {
                MessageBox.Show("Telefon 10 hane olmalı ve 0 ile başlamamalıdır!");
                return;
            }

            if (txtOkulNo.Text.Trim() != "" &&
                !txtOkulNo.Text.Trim().All(char.IsDigit))
            {
                MessageBox.Show("Okul numarası sadece rakamlardan oluşmalıdır!");
                return;
            }

            if (!IsValidPassword(txtSifre.Text.Trim()))
            {
                MessageBox.Show("Şifre en az 8 karakter olmalı, büyük, küçük harf ve rakam içermelidir!");
                return;
            }

          
            using (SqlConnection connEmail = new SqlConnection(connStr))
            {
                connEmail.Open();

                SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Kullanicilar WHERE Email=@m", connEmail);
                check.Parameters.AddWithValue("@m", txtEmail.Text.Trim());

                if ((int)check.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Bu e-mail zaten kayıtlı!");
                    return;
                }
            }

            using SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"
                INSERT INTO Kullanicilar (Ad, Soyad, Email, Sifre, OkulNo, Telefon, RolID)
                VALUES (@ad,@soyad,@mail,@sifre,@okul,@tel,@rol)", conn);

            cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
            cmd.Parameters.AddWithValue("@mail", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());
            cmd.Parameters.AddWithValue("@okul", txtOkulNo.Text.Trim() == "" ? DBNull.Value : txtOkulNo.Text.Trim());
            cmd.Parameters.AddWithValue("@tel", txtTelefon.Text.Trim() == "" ? DBNull.Value : txtTelefon.Text.Trim());

            // RolID'nin sadece rakam olduğundan emin olmalıyız.
            if (!int.TryParse(txtRol.Text.Trim(), out int rolId))
            {
                MessageBox.Show("Rol ID rakam olmalıdır (1:Öğrenci, 2:Personel, 3:Admin).");
                return;
            }
            cmd.Parameters.AddWithValue("@rol", rolId);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Kullanıcı eklendi!");
            ListeleOgrenciler();
            ListelePersoneller();
        }

       
        private bool IsValidEmail(string email)
        {
            return email.Contains("@") && !email.StartsWith("@") && !email.EndsWith("@");
        }

        private bool IsValidPhone(string tel)
        {
            return tel.Length == 10 && tel.All(char.IsDigit) && !tel.StartsWith("0");
        }

        private bool IsValidPassword(string pass)
        {
            return pass.Length >= 8 &&
                       pass.Any(char.IsUpper) &&
                       pass.Any(char.IsLower) &&
                       pass.Any(char.IsDigit);
        }

        private void SilKullanici(int id)
        {
            DialogResult result = MessageBox.Show(
                "Bu kullanıcıyı silmek istediğinizden emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            using SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Kullanicilar WHERE KullaniciID=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
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

        private void user_man_button_Click(object sender, EventArgs e) { } 

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
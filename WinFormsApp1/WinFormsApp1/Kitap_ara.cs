using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace WinFormsApp1
{
    public partial class Kitap_ara : Form
    {
        private readonly string _userName;
        private readonly string _userEmail;

        private const string PlaceholderYazar = "Kitap Yazarını Giriniz...";
        private const string PlaceholderAd = "Kitap Adını Giriniz...";

        
        public Kitap_ara()
        {
            InitializeComponent();
            _userName = "";
            _userEmail = "";

            ApplyStyle();
            InitializePage();
        }

        public Kitap_ara(string userName, string userEmail)
        {
            InitializeComponent();
            _userName = userName;
            _userEmail = userEmail;

            ApplyStyle();
            InitializePage();
        }

       
        private void ApplyStyle()
        {
            Color userMenuColor = Color.DarkGoldenrod;
            Color activeColor = Color.Goldenrod;
            Color exitColor = Color.Firebrick;
            Color foregroundColor = Color.White;

            ana_button.BackColor = userMenuColor;
            kitap_list_button.BackColor = userMenuColor;
            kitap_aara_button.BackColor = activeColor;
            odunc_talep_button.BackColor = userMenuColor;
            odunc_takip_button.BackColor = userMenuColor;
            exit_button.BackColor = exitColor;

            ana_button.ForeColor =
            kitap_list_button.ForeColor =
            kitap_aara_button.ForeColor =
            odunc_talep_button.ForeColor =
            odunc_takip_button.ForeColor =
            exit_button.ForeColor = foregroundColor;

            filtreleButton.BackColor = Color.SaddleBrown;
            filtreleButton.ForeColor = foregroundColor;
            filtreleButton.Font = new Font(filtreleButton.Font, FontStyle.Bold);

            StyleDataGridView(dataGridViewKitaplar, userMenuColor, Color.OldLace);
        }

        private void StyleDataGridView(DataGridView dgv, Color headerColor, Color altRowColor)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = altRowColor;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Peru;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
        }

       
        private void InitializePage()
        {
            SetupPlaceholders();
            LoadFilters();
            ListeleTumKitaplar();
            AddTalepButtonColumn();
            SetupLeftButtons();

            filtreleButton.Click += filtreleButton_Click;
            dataGridViewKitaplar.CellClick += dataGridViewKitaplar_CellClick;
        }

      
        private void SetupLeftButtons()
        {
            ana_button.Click += (s, e) =>
            {
                new UserPage(_userName, _userEmail).Show();
                this.Hide();
            };

            kitap_list_button.Click += (s, e) =>
            {
                new Kitap_List(_userName, _userEmail).Show();
                this.Hide();
            };

            odunc_talep_button.Click += (s, e) =>
            {
                new Odunc_Talep(_userName, _userEmail).Show();
                this.Hide();
            };

            odunc_takip_button.Click += (s, e) =>
            {
                new Odunc_Takip(_userName, _userEmail).Show();
                this.Hide();
            };

            exit_button.Click += (s, e) =>
            {
                new Form1().Show();
                this.Close();
            };
        }

        
        private void SetupPlaceholders()
        {
            yazarTextBox.Text = PlaceholderYazar;
            yazarTextBox.ForeColor = Color.Gray;

            yazarTextBox.Enter += (s, e) =>
            {
                if (yazarTextBox.Text == PlaceholderYazar)
                {
                    yazarTextBox.Text = "";
                    yazarTextBox.ForeColor = Color.Black;
                }
            };

            yazarTextBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(yazarTextBox.Text))
                {
                    yazarTextBox.Text = PlaceholderYazar;
                    yazarTextBox.ForeColor = Color.Gray;
                }
            };

            kitapAdiTextBox.Text = PlaceholderAd;
            kitapAdiTextBox.ForeColor = Color.Gray;

            kitapAdiTextBox.Enter += (s, e) =>
            {
                if (kitapAdiTextBox.Text == PlaceholderAd)
                {
                    kitapAdiTextBox.Text = "";
                    kitapAdiTextBox.ForeColor = Color.Black;
                }
            };

            kitapAdiTextBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(kitapAdiTextBox.Text))
                {
                    kitapAdiTextBox.Text = PlaceholderAd;
                    kitapAdiTextBox.ForeColor = Color.Gray;
                }
            };
        }

      
        
        private void AddTalepButtonColumn()
        {
            if (dataGridViewKitaplar.Columns.Contains("TalepButton"))
                return;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn
            {
                HeaderText = "Ödünç Talep",
                Name = "TalepButton",
                Text = "Talep Et",
                UseColumnTextForButtonValue = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.ForestGreen,
                    ForeColor = Color.White,
                    SelectionBackColor = Color.DarkGreen
                }
            };

            dataGridViewKitaplar.Columns.Add(btn);
        }

        
        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridViewKitaplar.Columns[e.ColumnIndex].Name == "TalepButton")
            {
                int stok = Convert.ToInt32(
                    dataGridViewKitaplar.Rows[e.RowIndex].Cells["StokAdedi"].Value
                );

                if (stok <= 0)
                {
                    MessageBox.Show(
                        "Bu kitap şu anda ödünç verilemez.\nStokta bulunmamaktadır.",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                MessageBox.Show(
                    "Talebiniz alınmıştır.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        
        private void ListeleTumKitaplar()
        {
            using SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;");
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT k.KitapID, k.KitapAdi, k.Yazar, k.ISBN,
                       k.YayinYili, k.StokAdedi, k.RafNo, k.Ozet,
                       ka.KategoriAdi
                FROM Kitaplar k
                INNER JOIN Kategoriler ka ON k.KategoriID = ka.KategoriID", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewKitaplar.DataSource = dt;
        }

        
        private void LoadFilters()
        {
            kategoriComboBox.Items.Clear();
            yilComboBox.Items.Clear();

            kategoriComboBox.Items.Add("Tümü");
            yilComboBox.Items.Add("Tümü");

            try
            {
                using SqlConnection conn = new SqlConnection(
                    "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;");
                conn.Open();

                using (SqlCommand cmd1 = new SqlCommand(
                    "SELECT KategoriAdi FROM Kategoriler", conn))
                using (SqlDataReader dr1 = cmd1.ExecuteReader())
                {
                    while (dr1.Read())
                        kategoriComboBox.Items.Add(dr1["KategoriAdi"].ToString());
                }

                using (SqlCommand cmd2 = new SqlCommand(
                    "SELECT DISTINCT YayinYili FROM Kitaplar ORDER BY YayinYili DESC", conn))
                using (SqlDataReader dr2 = cmd2.ExecuteReader())
                {
                    while (dr2.Read())
                        yilComboBox.Items.Add(dr2["YayinYili"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filtreler yüklenirken hata: " + ex.Message);
            }

            kategoriComboBox.SelectedIndex = 0;
            yilComboBox.SelectedIndex = 0;
        }

        
        private void filtreleButton_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;");
            conn.Open();

            string sql = @"
        SELECT k.KitapID, k.KitapAdi, k.Yazar, k.ISBN,
               k.YayinYili, k.StokAdedi, k.RafNo, k.Ozet,
               ka.KategoriAdi
        FROM Kitaplar k
        INNER JOIN Kategoriler ka ON k.KategoriID = ka.KategoriID
        WHERE 1=1";

            SqlCommand cmd = new SqlCommand { Connection = conn };

          
            if (kategoriComboBox.Text != "Tümü")
            {
                sql += " AND ka.KategoriAdi = @kat";
                cmd.Parameters.AddWithValue("@kat", kategoriComboBox.Text);
            }

          
            if (yilComboBox.Text != "Tümü")
            {
                sql += " AND k.YayinYili = @yil";
                cmd.Parameters.AddWithValue("@yil", yilComboBox.Text);
            }

           
            if (!string.IsNullOrWhiteSpace(yazarTextBox.Text) &&
                yazarTextBox.Text != PlaceholderYazar)
            {
                sql += " AND k.Yazar LIKE @yazar";
                cmd.Parameters.AddWithValue("@yazar", "%" + yazarTextBox.Text.Trim() + "%");
            }

            
            if (!string.IsNullOrWhiteSpace(kitapAdiTextBox.Text) &&
                kitapAdiTextBox.Text != PlaceholderAd)
            {
                sql += " AND k.KitapAdi LIKE @kitapAdi";
                cmd.Parameters.AddWithValue("@kitapAdi", "%" + kitapAdiTextBox.Text.Trim() + "%");
            }

            cmd.CommandText = sql;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewKitaplar.DataSource = dt;
        }


      
        private void ana_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}

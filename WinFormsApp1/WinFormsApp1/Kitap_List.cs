using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Drawing; 

namespace WinFormsApp1
{
    public partial class Kitap_List : Form
    {
        private readonly string _userName;
        private readonly string _userEmail;

        
        public Kitap_List()
        {
            InitializeComponent();
            _userName = "";
            _userEmail = "";
        }

       
        public Kitap_List(string userName, string userEmail)
        {
            InitializeComponent();
            _userName = userName;
            _userEmail = userEmail;

            

            ApplyStyle();

            ana_button.Click += ana_button_Click;
            kitap_list_button.Click += kitap_list_button_Click; 
            kitap_aara_button.Click += kitap_aara_button_Click;
            odunc_talep_button.Click += odunc_talep_button_Click;
            odunc_takip_button.Click += odunc_takip_button_Click;
            exit_button.Click += exit_button_Click;
        }

        private void ApplyStyle()
        {
            
            Color userMenuColor = Color.DarkGoldenrod;
            Color activeColor = Color.Goldenrod;
            Color exitColor = Color.Firebrick;
            Color foregroundColor = Color.White;

            
            ana_button.BackColor = userMenuColor;
            ana_button.ForeColor = foregroundColor;

            kitap_list_button.BackColor = activeColor; 
            kitap_list_button.ForeColor = foregroundColor;

            kitap_aara_button.BackColor = userMenuColor;
            kitap_aara_button.ForeColor = foregroundColor;

            odunc_talep_button.BackColor = userMenuColor;
            odunc_talep_button.ForeColor = foregroundColor;

            odunc_takip_button.BackColor = userMenuColor;
            odunc_takip_button.ForeColor = foregroundColor;

            exit_button.BackColor = exitColor;
            exit_button.ForeColor = foregroundColor;

            
            StyleDataGridView(dataGridViewKitaplar, userMenuColor, Color.OldLace);
        }

        
        private void StyleDataGridView(DataGridView dgv, Color headerColor, Color altRowColor)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;

            
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font.FontFamily, 10, FontStyle.Bold);

            
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = altRowColor;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Peru;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.BackgroundColor = Color.WhiteSmoke;
        }

        private void Kitap_List_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(
                    "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;"))
                {
                    conn.Open();

                    string sql = "SELECT KitapID, KitapAdi, Yazar, ISBN, YayinYili, StokAdedi, RafNo FROM Kitaplar"; 

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewKitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar yüklenirken hata oluştu:\n" + ex.Message);
            }
        }

        private void ana_button_Click(object sender, EventArgs e)
        {
            UserPage p = new UserPage(_userName, _userEmail);
            p.Show();
            this.Hide();
        }

        private void kitap_list_button_Click(object sender, EventArgs e)
        {
            
        }

        private void kitap_aara_button_Click(object sender, EventArgs e)
        {
            Kitap_ara k = new Kitap_ara(_userName, _userEmail);
            k.Show();
            this.Hide();
        }

        private void odunc_talep_button_Click(object sender, EventArgs e)
        {
            Odunc_Talep o = new Odunc_Talep(_userName, _userEmail);
            o.Show();
            this.Hide();

        }

        private void odunc_takip_button_Click(object sender, EventArgs e)
        {
            Odunc_Takip t = new Odunc_Takip(_userName, _userEmail);
            t.Show();
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
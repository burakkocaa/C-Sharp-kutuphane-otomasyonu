using Kutuphane.Business.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.Forms
{
    public partial class IslemlerListesi : Form
    {
        public IslemlerListesi()
        {
            InitializeComponent();
        }
        public IslemlerListesi(FormWindowState windowState, Point location) // Daha iyi bir konum için formların yapıcı metotlarına overloading yaptım
        {
            InitializeComponent();
            this.WindowState = windowState;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
        }
        private void IslemlerListesi_Load(object sender, EventArgs e)
        {
            EmanetIslemleriManager emanetIslemleriManager = new EmanetIslemleriManager();
            DataSet dataSet;
            dataSet = emanetIslemleriManager.listele();
            
            dataGridViewIslemler.DataSource = dataSet.Tables[0];
            dataGridViewIslemler.ClearSelection();

            DateTime teslimTarihi;
            TimeSpan gecikenGun;

            foreach (DataGridViewRow row in dataGridViewIslemler.Rows) // Her emanet işlemi için
            {
                // teslim tarihini alarak bugünün tarihi ile işlem yap
                teslimTarihi = DateTime.Parse(row.Cells["teslimTarihi"].Value.ToString());
                gecikenGun = teslimTarihi.Subtract(DateTime.Now);

                if (Boolean.Parse(row.Cells["teslimDurumu"].Value.ToString())) 
                {
                    row.DefaultCellStyle.BackColor = Color.Green; // Teslim etmişse yeşil
                }
                else if (gecikenGun.Days < 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red; // Teslim gecikmişse kırmızı
                }
                else if (gecikenGun.Days <= 2)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow; // Teslime 0-2 gün kaldıysa sarı
                }
            }
            // Tablomun başlıklarını düzenledim
            dataGridViewIslemler.Columns[0].HeaderText = "İşlem ID";
            dataGridViewIslemler.Columns[1].HeaderText = "Öğrenci ID";
            dataGridViewIslemler.Columns[2].HeaderText = "Kitap ID";
            dataGridViewIslemler.Columns[3].HeaderText = "Teslim Tarihi";
            dataGridViewIslemler.Columns[4].HeaderText = "İşlem Tarihi";
            dataGridViewIslemler.Columns[5].HeaderText = "Teslim Durumu";
            dataGridViewIslemler.Columns[6].HeaderText = "Teslim Edilen Tarih";
        }
        private void dataGridViewIslemler_ColumnAdded(object sender, DataGridViewColumnEventArgs e) // Tablo üzerindeki sıralamayı değiştirmeyi kapattım
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void button_mousehover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(179, 0, 0);
        }
        private void button_mouseleave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Maroon;
        }
        private void btn_kitaplar_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar(this.WindowState, this.Location);
            kitaplar.Show();
            this.Close();
        }
        private void btn_ogrenciler_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenciler = new Ogrenciler(this.WindowState, this.Location);
            ogrenciler.Show();
            this.Close();
        }
        private void btn_grafik_Click(object sender, EventArgs e)
        {
            Grafik grafik = new Grafik(this.WindowState, this.Location);

            grafik.Show();
            this.Close();
        }
    }
}

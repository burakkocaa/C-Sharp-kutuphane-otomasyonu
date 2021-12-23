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
    public partial class Ogrenciler : Form
    {
        /* Global Variables */
        DataSet dataSet;
        public Ogrenciler()
        {
            InitializeComponent(); 
        }
        public Ogrenciler(FormWindowState windowState, Point location) // Daha iyi bir konum için formların yapıcı metotlarına overloading yaptım
        {
            InitializeComponent();
            // Form yerini önceki forma göre ayarlıyor
            this.WindowState = windowState;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
        }
        public void tabloGuncelle() // İşlemlerden sonra tabloyu güncellemek için bir fonksiyon tasarladım
        {
            // Öğrencileri listele, dataGridView'a at
            OgrenciManager ogrenciManager = new OgrenciManager();
            dataSet = ogrenciManager.listele();

            dataGridViewOgrenciler.DataSource = dataSet.Tables[0];
            dataGridViewOgrenciler.Columns.Remove("kitapAlabilirMi"); // bunun listelenmesine gerek yok
            dataGridViewOgrenciler.ClearSelection(); // Otomatik seçimi kaldırmak için
        }
        private void Ogrenciler_Load(object sender, EventArgs e)
        {
            tabloGuncelle();
            // Tablonun başlıklarını daha güzel hale getirdim
            dataGridViewOgrenciler.Columns[0].HeaderText = "ID";
            dataGridViewOgrenciler.Columns[1].HeaderText = "Öğrenci Adı";
            dataGridViewOgrenciler.Columns[2].HeaderText = "Soyadı";
            dataGridViewOgrenciler.Columns[3].HeaderText = "Öğrenci No";
            dataGridViewOgrenciler.Columns[4].HeaderText = "TC Kimlik No";
            dataGridViewOgrenciler.Columns[5].HeaderText = "Tel No";
            dataGridViewOgrenciler.Columns[6].HeaderText = "Borç";
        }
        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e) // Tablo üzerindeki sıralamayı değiştirmeyi kapattım
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void button_mousehover(object sender, EventArgs e) // Bütün butonların hover olayı
        {
            ((Button)sender).BackColor = Color.FromArgb(179, 0, 0);
            
        }
        private void button_mouseleave(object sender, EventArgs e) // Bütün butonların leave olayı
        {
            ((Button)sender).BackColor = Color.Maroon;
        }
        private void btn_kitaplar_Click(object sender, EventArgs e) // Yeni form sayfasına geçiş
        {
            Kitaplar kitaplar = new Kitaplar(this.WindowState, this.Location);  // Bu formun konum ve boyut bilgilerini gönderiyorum
            kitaplar.Show(); 
            this.Close();
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.ShowDialog(this);  // ShowDialog olarak yeni bir form gösteriyorum

            tabloGuncelle();
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewOgrenciler.SelectedRows.Count == 1) // Eğer tabloda seçim yapıldıysa
            {
                int ogrenciID = Int32.Parse(dataGridViewOgrenciler.SelectedRows[0].Cells[0].Value.ToString()); // Seçilen satırın öğrenci ID'sini al

                OgrenciGuncelle ogrenciGuncelle = new OgrenciGuncelle(ogrenciID); // Bu ID parametresi ile yeni form oluştur

                ogrenciGuncelle.ShowDialog(this);

                tabloGuncelle();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci seçiniz.");
            }    
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dataGridViewOgrenciler.SelectedRows.Count == 1) // Eğer tabloda seçim yapıldıysa
            {
                // Silmek tehlikelidir. Bunun için bir uyarı mesajı gerekli
                DialogResult dialogResult = MessageBox.Show(dataGridViewOgrenciler.SelectedRows[0].Cells[1].Value.ToString() + " adlı öğrenciyi silmek istediğinize emin misiniz ? ", "Uyarı", MessageBoxButtons.YesNo);
                
                if (dialogResult == DialogResult.Yes) // Kullanıcı eminse sil
                {
                    OgrenciManager ogrenciManager = new OgrenciManager();

                    ogrenciManager.sil(Int32.Parse(dataGridViewOgrenciler.SelectedRows[0].Cells[0].Value.ToString())); // Seçilen satırın öğrenci ID'sini al ve sil

                    dataSet = ogrenciManager.listele(); // işlemden sonra güncel verileri çek
                    dataGridViewOgrenciler.DataSource = dataSet.Tables[0];

                    tabloGuncelle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci seçiniz.");
            }
        }
        private void btn_islem_Click(object sender, EventArgs e) 
        {
            if (dataGridViewOgrenciler.SelectedRows.Count == 1) // Eğer tabloda seçim yapıldıysa
            {
                int ogrenciID = Int32.Parse(dataGridViewOgrenciler.SelectedRows[0].Cells[0].Value.ToString()); // Seçilen satırın öğrenci ID'sini al
                OgrenciIslemleri ogrenciIslemleri = new OgrenciIslemleri(this.WindowState, this.Location, ogrenciID);

                ogrenciIslemleri.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci seçiniz.");
            }
        }
        private void btn_islemler_Click(object sender, EventArgs e)
        {
            IslemlerListesi islemlerListesi = new IslemlerListesi(this.WindowState, this.Location);

            islemlerListesi.Show();
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

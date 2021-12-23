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
    public partial class Kitaplar : Form
    {
        /* Global Variables */
        DataSet dataSet;
        public Kitaplar()
        {
            
            InitializeComponent();
            
        }
        public Kitaplar(FormWindowState windowState, Point location) // Daha iyi bir konum için formların yapıcı metotlarına overloading yaptım
        {
            InitializeComponent();
            // Form yerini önceki forma göre ayarlıyor
            this.WindowState = windowState;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
        }
        public void tabloGuncelle() // İşlemlerden sonra tabloyu güncellemek için bir fonksiyon tasarladım
        {
            // Kitapları listele, dataGridView'a at
            KitapManager kitapManager = new KitapManager();
            dataSet = kitapManager.listele();

            dataGridViewKitaplar.DataSource = dataSet.Tables[0];
            dataGridViewKitaplar.ClearSelection(); // Otomatik seçimi kaldırmak için
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            // textBoxArama'nın içine bilgi mesajı yazabilmek için event ekledim. (Watermark)
            this.textBoxArama.Leave += new System.EventHandler(this.textBoxArama_Leave);
            this.textBoxArama.Enter += new System.EventHandler(this.textBoxArama_Enter);
            textBoxArama.ForeColor = SystemColors.GrayText;

            EmanetIslemleriManager emanetIslemleriManager = new EmanetIslemleriManager();
            
            // İlk formum aynı zamanda Kitaplar olduğu için program ilk açıldığında borç hesaplaması yapıyorum
            emanetIslemleriManager.borcHesapla(); 

            
            tabloGuncelle();
            // Tablonun başlıklarını daha güzel hale getirdim
            dataGridViewKitaplar.Columns[0].HeaderText = "ID";
            dataGridViewKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dataGridViewKitaplar.Columns[2].HeaderText = "Yazar";
            dataGridViewKitaplar.Columns[3].HeaderText = "Tür";
            dataGridViewKitaplar.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridViewKitaplar.Columns[5].HeaderText = "Stok Adedi";
        }
        private void dataGridViewKitaplar_ColumnAdded(object sender, DataGridViewColumnEventArgs e) // Tablo üzerindeki sıralamayı değiştirmeyi kapattım
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

        private void btn_ogrenciler_Click(object sender, EventArgs e) // Yeni form sayfasına geçiş
        {
            
            Ogrenciler ogrenciler = new Ogrenciler(this.WindowState, this.Location); // Bu formun konum ve boyut bilgilerini gönderiyorum
            ogrenciler.Show();
            this.Hide();
        }

        private void textBoxArama_Enter(object sender, EventArgs e)
        {
            if (textBoxArama.Text == "Kitap ID veya İsmi Giriniz..") // Veri girmek için tıklandığında yazı siliniyor
            {
                textBoxArama.Text = "";
                textBoxArama.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBoxArama_Leave(object sender, EventArgs e)
        {
            if (textBoxArama.Text.Length == 0) // Veri girmekten vazgeçildiğinde tekrar textboxa bilgi mesajı yazılıyor
            {
                textBoxArama.Text = "Kitap ID veya İsmi Giriniz..";
                textBoxArama.ForeColor = SystemColors.GrayText;
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.ShowDialog(this); // ShowDialog olarak yeni bir form gösteriyorum

            tabloGuncelle();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if(dataGridViewKitaplar.SelectedRows.Count == 1) // Eğer tabloda seçim yapıldıysa
            {
                int kitapID = Int32.Parse(dataGridViewKitaplar.SelectedRows[0].Cells[0].Value.ToString()); // Seçilen satırın öğrenci ID'sini al

                KitapGuncelle kitapGuncelle = new KitapGuncelle(kitapID); // Bu ID parametresi ile yeni form oluştur


                kitapGuncelle.ShowDialog(this);

                tabloGuncelle();
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçiniz.");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dataGridViewKitaplar.SelectedRows.Count == 1) // Eğer tabloda seçim yapıldıysa
            {
                // Silmek tehlikelidir. Bunun için bir uyarı mesajı gerekli
                DialogResult dialogResult = MessageBox.Show(dataGridViewKitaplar.SelectedRows[0].Cells[1].Value.ToString() + " adlı kitabı silmek istediğinize emin misiniz ? ", "Uyarı", MessageBoxButtons.YesNo);
                
                if (dialogResult == DialogResult.Yes) // Kullanıcı eminse sil
                {
                    KitapManager kitapManager = new KitapManager();

                    kitapManager.sil(Int32.Parse(dataGridViewKitaplar.SelectedRows[0].Cells[0].Value.ToString()));

                    dataSet = kitapManager.listele(); // işlemden sonra güncel verileri çek
                    dataGridViewKitaplar.DataSource = dataSet.Tables[0];
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçiniz.");
            } 
        }
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (textBoxArama.Text.Trim().Equals("") || textBoxArama.Text.Trim().Equals("Kitap ID veya İsmi Giriniz..")) // Veri girilmezse uyar
            {
                MessageBox.Show("Lütfen Aramak istediğiniz kitabın ID'sini veya Adını giriniz..");
            }
            else
            {
                KitapDetay kitapDetay;

                int parsedValue;
                if (int.TryParse(textBoxArama.Text, out parsedValue))  // texti inte çevirebiliyorsan ID ile ara
                {
                   
                    kitapDetay = new KitapDetay(parsedValue);
                }
                else // Çeviremiyorsan Ad ile ara
                {
                    kitapDetay = new KitapDetay(textBoxArama.Text);
                }

                kitapDetay.ShowDialog();
            }
        }
        private void btn_islemler_Click(object sender, EventArgs e)
        {
            IslemlerListesi islemlerListesi = new IslemlerListesi(this.WindowState, this.Location);

            islemlerListesi.Show();
            this.Hide();
        }
        private void btn_grafik_Click(object sender, EventArgs e)
        {
            Grafik grafik = new Grafik(this.WindowState, this.Location);

            grafik.Show();
            this.Hide();
        }
    }
}

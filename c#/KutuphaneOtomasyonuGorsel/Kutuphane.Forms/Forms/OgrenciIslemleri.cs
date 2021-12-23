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
    public partial class OgrenciIslemleri : Form
    {
        /* Global Variables */
        int ogrenciID = 0;
        int tarihiGecmisSayac = 0;
        DataSet dataSetOgrenci, dataSetKitap, dataSetEmanet;

        OgrenciManager ogrenciManager = new OgrenciManager();
        EmanetIslemleriManager emanetIslemleriManager = new EmanetIslemleriManager();
        KitapManager kitapManager = new KitapManager();
        public OgrenciIslemleri()
        {
            InitializeComponent();
        }
        // Daha iyi bir konum için formların yapıcı metotlarına overloading yaptım
        public OgrenciIslemleri(FormWindowState windowState, Point location, int ogrenciID) 
        {
            InitializeComponent();
            this.ogrenciID = ogrenciID;
            this.WindowState = windowState;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
        }
        public void tabloGuncelle() // İşlemlerden sonra tabloyu güncellemek için bir fonksiyon tasarladım
        {
            tarihiGecmisSayac = 0;
            DataTable emanetTablo = new DataTable();
            // Tabloma başlıklar ekledim
            emanetTablo.Columns.Add("İşlem ID", typeof(int));
            emanetTablo.Columns.Add("Kitap ID", typeof(int));
            emanetTablo.Columns.Add("Kitap Adı", typeof(string));
            emanetTablo.Columns.Add("Emanet Tarihi", typeof(DateTime));
            emanetTablo.Columns.Add("Teslim Tarihi", typeof(DateTime));
            emanetTablo.Columns.Add("Teslim Durumu", typeof(Boolean));
            emanetTablo.Columns.Add("Teslim Edilen Tarih", typeof(DateTime));

            dataSetOgrenci = ogrenciManager.ara(ogrenciID);
            dataSetKitap = kitapManager.listele();
            dataSetEmanet = emanetIslemleriManager.ara(ogrenciID, "öğrenci");

            dataGridViewKitaplar.DataSource = dataSetKitap.Tables[0];

            foreach (DataTable table in dataSetEmanet.Tables)
            {
                foreach (DataRow row in table.Rows) // Tablonun satırlarına ulaşmak için döngü kullandım
                {
                    dataSetKitap = kitapManager.ara(Int32.Parse(row["kitapID"].ToString())); // Kitabın verilerini aldım

                    // Aldığım verileri tabloya ekledim
                    emanetTablo.Rows.Add(Int32.Parse(row["ID"].ToString()), Int32.Parse(dataSetKitap.Tables[0].Rows[0]["ID"].ToString()), dataSetKitap.Tables[0].Rows[0]["ad"].ToString(), 
                        row["emanetTarihi"], row["teslimTarihi"], row["teslimDurumu"], row["teslimEdilenTarih"]);

                    DateTime now = DateTime.Now;
                    DateTime teslimTarihi = DateTime.Parse(row["teslimTarihi"].ToString());
                    TimeSpan gecikenGun = teslimTarihi.Subtract(now);
                    Boolean teslimDurumu = Boolean.Parse(row["teslimDurumu"].ToString());

                    dataGridViewEmanet.DataSource = emanetTablo;
                    
                    // Tabloları renklerdirdim
                    if (teslimDurumu)
                    {
                        dataGridViewEmanet.Rows[tarihiGecmisSayac].DefaultCellStyle.BackColor = Color.Green;
                    }
                    else if (gecikenGun.Days<0)
                    {
                        dataGridViewEmanet.Rows[tarihiGecmisSayac].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (gecikenGun.Days<=2)
                    {
                        dataGridViewEmanet.Rows[tarihiGecmisSayac].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    tarihiGecmisSayac += 1;
                }
            }
            dataGridViewEmanet.DataSource = emanetTablo;

            // Tablolardaki seçim sıfırlama
            dataGridViewKitaplar.ClearSelection();
            dataGridViewEmanet.ClearSelection();

            // Kitap tablosunun başlıkları
            dataGridViewKitaplar.Columns[0].HeaderText = "Kitap ID";
            dataGridViewKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dataGridViewKitaplar.Columns[2].HeaderText = "Yazar";
            dataGridViewKitaplar.Columns[3].HeaderText = "Tür";
            dataGridViewKitaplar.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridViewKitaplar.Columns[5].HeaderText = "Stok Adedi";
        }
        private void OgrenciIslemleri_Load(object sender, EventArgs e)
        {
            tabloGuncelle();

            // Yapıcı fonksiyondan aldığımız ID sayesinde ada ve borca ulaştım
            lbl_hosgeldiniz.Text = dataSetOgrenci.Tables[0].Rows[0]["ad"].ToString() + " adı altında işlem yapmaktasınız."; 
            lbl_borc.Text = "Borcunuz : " + dataSetOgrenci.Tables[0].Rows[0]["borc"].ToString() + "₺";
        }
        private void dataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e) // Tablo üzerindeki sıralamayı değiştirmeyi kapattım
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void btn_geri_Click(object sender, EventArgs e) // Öğrenciler formuna geri dönüyoruz
        {
            Ogrenciler ogrenciler = new Ogrenciler(this.WindowState, this.Location);

            ogrenciler.Show();

            this.Close();
        }
        private void btn_emanet_Click(object sender, EventArgs e)
        {
            if (dataGridViewKitaplar.SelectedRows.Count == 1) // Eğer tabloda seçim yapıldıysa
            {
                int kitapID = Int32.Parse(dataGridViewKitaplar.SelectedRows[0].Cells[0].Value.ToString()); // Seçilen satırın kitap ID'sini al
                if (!emanetIslemleriManager.kitapAlma(ogrenciID, kitapID)) // emanet işlemi yapmayı dene, başarısız olursa uyar
                {
                    MessageBox.Show("İade etmediğiniz kitap bulunmakta veya stok yetersiz.");
                }

                tabloGuncelle();
            }
            else
            {
                MessageBox.Show("Almak istediğiniz kitabı seçiniz.");
            }
        }
        private void btn_iade_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmanet.SelectedRows.Count == 1) // Eğer tabloda seçim yapıldıysa
            {
                int islemID = Int32.Parse(dataGridViewEmanet.SelectedRows[0].Cells[0].Value.ToString()); // Seçilen satırın işlem ID'sini al
                int kitapID = Int32.Parse(dataGridViewEmanet.SelectedRows[0].Cells[1].Value.ToString()); // Seçilen satırın kitap ID'sini al

                // emanet iade yapmayı dene, başarısız olursa uyar
                if (emanetIslemleriManager.kitapIade(islemID, kitapID, ogrenciID)) 
                { 
                    MessageBox.Show("İade işlemi başarılı.");
                    lbl_borc.Text = "Borcunuz : 0₺";
                }
                else
                {
                    MessageBox.Show("Zaten iade edilmiş.");
                }
                tabloGuncelle();
            }
            else
            {
                MessageBox.Show("İade etmek istediğiniz kitabı seçiniz.");
            }
        }
    }
}

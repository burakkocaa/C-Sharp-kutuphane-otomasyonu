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
using ZedGraph;

namespace Kutuphane.Forms
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }
        public Grafik(FormWindowState windowState, Point location) // Daha iyi bir konum için formların yapıcı metotlarına overloading yaptım
        {
            InitializeComponent();
            this.WindowState = windowState;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
        }
        private void Grafik_Load(object sender, EventArgs e)
        {
            GraphPane myPane = zedGraphGrafik.GraphPane;
            KitapManager kitapManager = new KitapManager();
            EmanetIslemleriManager emanetIslemleriManager = new EmanetIslemleriManager();

            // Veritabanından verileri çektim
            int kitapSayisi = kitapManager.kitapSayisi();
            int emanetVerilenKitapSayisi = emanetIslemleriManager.emanetVerilenKitapSayisi();
            int mevcutKitapSayisi = kitapSayisi - emanetVerilenKitapSayisi;

            // Bar için verileri double'a çevirdim
            double[] bar1 = { kitapSayisi };
            double[] bar2 = { emanetVerilenKitapSayisi };
            double[] bar3 = { mevcutKitapSayisi };

            // Grafik için Bar oluşturdum

            // Yeşil Kitap Sayısı Barı
            BarItem myBar = myPane.AddBar("Kitap Sayısı", null, bar1, Color.Green);
            myBar.Bar.Fill = new Fill(Color.Green, Color.White, Color.Green);

            // Kırmızı Emanet Verilen Kitap Sayısı Barı
            myBar = myPane.AddBar("Emanet Verilen Kitap Sayısı", null, bar2, Color.Red);
            myBar.Bar.Fill = new Fill(Color.Red, Color.White, Color.Red);

            // Mavi Mevcut Kitap Sayısı
            myBar = myPane.AddBar("Mevcut Kitap Sayısı", null, bar3, Color.Blue);
            myBar.Bar.Fill = new Fill(Color.Blue, Color.White, Color.Blue);

            // Tasarım
            myPane.XAxis.MajorTic.IsBetweenLabels = true;
            myPane.XAxis.Type = AxisType.Text;

            // Arkaplan
            myPane.Chart.Fill = new Fill(Color.White, Color.White);
            myPane.Fill = new Fill(Color.WhiteSmoke);

            // Başlıklar
            myPane.Title.Text = "Kütüphane Stok Durumu Grafiği";
            myPane.XAxis.Title.Text = "Kütüphane Analizi";
            myPane.YAxis.Title.Text = "Kütüphane Stok Durumu Grafiği";
            myPane.Border.IsVisible = false;
            myPane.Legend.Position = LegendPos.TopCenter;
            myPane.Title.IsVisible = false;

            zedGraphGrafik.AxisChange();
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
        private void btn_islemler_Click(object sender, EventArgs e)
        {
            IslemlerListesi islemlerListesi = new IslemlerListesi(this.WindowState, this.Location);

            islemlerListesi.Show();
            this.Close();
        }
    }
}

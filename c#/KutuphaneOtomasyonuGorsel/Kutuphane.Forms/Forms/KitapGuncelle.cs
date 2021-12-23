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
    public partial class KitapGuncelle : Form
    {
        /* Global Variables */
        int kitapID = 0;
        public KitapGuncelle()
        {
            InitializeComponent();
        }
        public KitapGuncelle(int kitapID)
        {
            this.kitapID = kitapID;
            InitializeComponent();
        }
        private void KitapGuncelle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Formun çerçevesini kapat
            KitapManager kitapManager = new KitapManager();

            DataSet dataSet = kitapManager.ara(kitapID);

            // Güncellemek istediğimiz kitabın verilerini textboxlara yazdırdım
            tb_ad.Text = dataSet.Tables[0].Rows[0]["ad"].ToString();
            tb_yazar.Text = dataSet.Tables[0].Rows[0]["yazar"].ToString();
            tb_tur.Text = dataSet.Tables[0].Rows[0]["tur"].ToString();
            tb_sayfa.Text = dataSet.Tables[0].Rows[0]["sayfa"].ToString();
            tb_stok.Text = dataSet.Tables[0].Rows[0]["stok"].ToString();
        }
        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (tb_ad.Text.Equals("") || tb_yazar.Text.Equals("") || tb_tur.Text.Equals("") || tb_sayfa.Text.Equals("") || tb_stok.Text.Equals("")) // textboxlar boş mu kontrol ettim
            {
                MessageBox.Show("Lütfen boş geçmeyiniz.");
            }
            else
            {
                KitapManager kitapManager = new KitapManager();
                if (!kitapManager.guncelle(kitapID, tb_ad.Text, tb_yazar.Text, tb_tur.Text, tb_sayfa.Text, tb_stok.Text))  // Güncelleme işlemini yapmayı denedim. Başarısız olursa uyardım
                {
                    MessageBox.Show("Lütfen sayısal değerlere dikkat ediniz.");
                }
                else this.Close();
            }
        }
    }
}

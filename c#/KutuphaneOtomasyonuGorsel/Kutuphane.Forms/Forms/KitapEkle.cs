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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        private void KitapEkle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
        }
        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            // textboxlar boş mu kontrol ettim
            if (tb_ad.Text.Equals("") || tb_yazar.Text.Equals("") || tb_tur.Text.Equals("") || tb_sayfa.Text.Equals("") || tb_stok.Text.Equals("")) 
            {
                MessageBox.Show("Lütfen boş geçmeyiniz.");
            }
            else
            {
                KitapManager kitapManager = new KitapManager();

                // Ekleme işlemini yapmayı denedim. Başarısız olursa uyardım
                if (!kitapManager.ekle(tb_ad.Text, tb_yazar.Text, tb_tur.Text, tb_sayfa.Text, tb_stok.Text))  
                {
                    MessageBox.Show("Lütfen sayısal değerlere dikkat ediniz.");
                }
                else this.Close();
            }
        }
    }
}
